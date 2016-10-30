using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucySpa.Properties;

namespace LucySpa.Citas
{
    using RowCita = LucySpa.DataAccess.LucySpaDB.CitasRow;
    public partial class frmCitaPago : MetroFramework.Forms.MetroForm
    {
        string EstadoCompra = "Efectivo";
        int CitaID;
        decimal CostoServicio;
        Inicio frmPrincipal;
        DataAccess.LucySpaDBTableAdapters.CitasTableAdapter taCitas = new DataAccess.LucySpaDBTableAdapters.CitasTableAdapter();
        DataAccess.LucySpaDBTableAdapters.VentaTarjetasTableAdapter taVentaTarjetas = new DataAccess.LucySpaDBTableAdapters.VentaTarjetasTableAdapter();
        public frmCitaPago(int CitaID, decimal CostoServicio,Inicio frmPrincipal)
        {
            InitializeComponent();
            this.CitaID = CitaID;
            this.CostoServicio = CostoServicio;
            tbTotal.Text = CostoServicio.ToString();
            this.frmPrincipal=frmPrincipal;
        }

        private void CitaPago_Load(object sender, EventArgs e)
        {

        }
        private void tbAPagar_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(tbAPagar.Text))
                tbAPagar.Text = "0.0";

            //se obtiene el dinero con el que se pagara
            decimal dinero = decimal.Parse(tbAPagar.Text);
            //se obtiene el dinero con el que se pagara
            decimal totalDeLaVenta = decimal.Parse(tbTotal.Text);

            decimal cambio;
            //Se calcula el cambio
            if (dinero > totalDeLaVenta)
                cambio = dinero - totalDeLaVenta;
            else
                cambio = 0;

            //se muestra en el textbox el cambio que se deve de dar al cliente
            tbCambio.Text = cambio.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Se crea table adapter para obtener los datos de la cita que se quiere modificar//
            if (EstadoCompra == "Efectivo") {
                RowCita Fila = taCitas.GetDataByCitaID(CitaID)[0];
                int servicioID = Fila.ServicioID;
                int empleadoID = Fila.EmpleadoID;
                int clienteID = Fila.ClienteID;
                DateTime fechaCita = Fila.Fecha;
                //Estos campos se ocuparan mas adelante ya que este relacionado bien tratamiento y tarjeta con citas//
                //int tratamientoID = Fila.TratamientoID;
                //int tarjetaID = Fila.VentaTarjeta;
                taCitas.UpdateQueryCitaID(clienteID, empleadoID, servicioID, fechaCita, null, null, true, CitaID);
                MessageBox.Show("Se ha realizado el pago satisfactoriamente", Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //se cierra esta ventana
                this.Close();
                frmPrincipal.actualizarRegistroCita();
            } else if (EstadoCompra == "Tarjeta")
            {
                RowCita Fila = taCitas.GetDataByCitaID(CitaID)[0];
                int servicioID = Fila.ServicioID;
                int empleadoID = Fila.EmpleadoID;
                int clienteID = Fila.ClienteID;
                DateTime fechaCita = Fila.Fecha;
                string tarjetaCliente;


                try
                {
                    DataAccess.LucySpaDB.VentaTarjetasRow renglon = taVentaTarjetas.GetDataByClienteID(clienteID)[0];
                    tarjetaCliente = taVentaTarjetas.QueryTipoTarjetaDelCliente(clienteID);
                    if (renglon.IsFechaTerminacionNull())
                    {
                        if (tarjetaCliente == "PREMIUM")
                        {
                            int contador = (int)taCitas.contarPagosConTarjeta(renglon.VentaTarjetaID);
                            if (contador <= 3)
                            {

                                taCitas.UpdateQueryCitaID(clienteID, empleadoID, servicioID, fechaCita, null, renglon.VentaTarjetaID, true, CitaID);
                                if (contador == 3)
                                {
                                    taVentaTarjetas.UpdateQueryVentaTarjetaID(clienteID, renglon.TarjetaID, renglon.FecchaCompra, DateTime.Today, renglon.VentaTarjetaID);
                                    MessageBox.Show("La tarjeta a expirado con este ultimo pago porfavor retire la tarjeta al cliente", "Tarjeta terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                MessageBox.Show("Se ha realizado el pago satisfactoriamente con la VIP CARD", Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //se cierra esta ventana
                                this.Close();
                                frmPrincipal.actualizarRegistroCita();
                            }
                        }else if (tarjetaCliente == "GIFT CARD")
                        {
                            taCitas.UpdateQueryCitaID(clienteID, empleadoID, servicioID, fechaCita, null, renglon.VentaTarjetaID, true, CitaID);
                            taVentaTarjetas.UpdateQueryVentaTarjetaID(clienteID, renglon.TarjetaID, renglon.FecchaCompra, DateTime.Today, renglon.VentaTarjetaID);
                            MessageBox.Show("Se ha realizado el pago satisfactoriamente con la " + tarjetaCliente + ". Profavor retire la tarjeta al cliente", Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //se cierra esta ventana
                            this.Close();
                            frmPrincipal.actualizarRegistroCita();
                        }
                        else
                        {
                            taCitas.UpdateQueryCitaID(clienteID, empleadoID, servicioID, fechaCita, null, renglon.VentaTarjetaID, true, CitaID);
                            taVentaTarjetas.UpdateQueryVentaTarjetaID(clienteID, renglon.TarjetaID, renglon.FecchaCompra, DateTime.Today, renglon.VentaTarjetaID);
                            MessageBox.Show("Se ha realizado el pago satisfactoriamente con la " + tarjetaCliente + ". Profavor retire la tarjeta al cliente", Resources.strExitoso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //se cierra esta ventana
                            this.Close();
                            frmPrincipal.actualizarRegistroCita();
                        }
                            

                    }
                    else
                    {
                        MessageBox.Show("Usted no puede realizar pagos con tarjeta por que ya a realizado los pagos equivalentes a su tarjeta", "Tarjeta terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch
                {

                    MessageBox.Show("Usted no puede realizar pagos con tarjeta por que ya a realizado los pagos equivalentes a su tarjeta", "Tarjeta terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
           
            }
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            EstadoCompra = "Tarjeta";
            if (btnTarjeta.Text=="Tarjeta")
            {
                btnTarjeta.Text = "Efectivo";
                gbEfectivo.Text = "Pago con tarjeta";
                tbAPagar.Visible = false;
                tbCambio.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                label2.Visible = true;
                label2.Text = "El Costo Se Descontara De Su Tarjeta";
                EstadoCompra = "Tarjeta";
            }else
            if (btnTarjeta.Text == "Efectivo")
            {
                EstadoCompra = "Efectivo";
                btnTarjeta.Text = "Tarjeta";
                tbCambio.Visible = true;
                tbAPagar.Visible = true;
                label3.Visible = true;
                gbEfectivo.Text = "Pago en efectivo";
                label4.Visible = true;
                label2.Visible = false;
            }
        }

        private void gbEfectivo_Enter(object sender, EventArgs e)
        {

        }
    }
}
