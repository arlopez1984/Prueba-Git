using Entidades.RHSGMT001;
using Negocio;
using Sage500AppModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHSGPR001
{
    public partial class frmMovimientos : Form
    {
        List<clsMovimiento> listaMov;
        ControllerRHSMTM001 controler;
        ControlllerRHSMP001 access;
        string conection;
        public clsMovimiento movement;
        public frmMovimientos(List<clsMovimiento> listamovimientos, string conect)
        {
            InitializeComponent();
            controler = new ControllerRHSMTM001();
            access = new ControlllerRHSMP001();
            listaMov = listamovimientos;
            conection = conect;
            MostrarMovimientosTrabajador(listaMov, conection);
            menuBar1.Items[3].Visible = false;
            menuBar1.Items[1].Visible = false;
        }
        public void MostrarMovimientosTrabajador(List<clsMovimiento> listado, string conex)
        {
            try
            {
                ListViewItem item ;
                foreach (clsMovimiento mov in listado)
                {                    
                    item = new ListViewItem();
                    item.Text = controler.GetMoviemientoxKey(mov.movementkey, conex);
                    item.SubItems.Add(mov.fechaMovement.ToString());
                    ControllerRHSMUO001 access = new ControllerRHSMUO001();
                    var unidad = access.GetUnidadOrganizativaKey(mov.unidadOrgKey, conex);
                    item.SubItems.Add(unidad.Name);
                    ControllerRHSMC001 control = new ControllerRHSMC001();
                    var cargo = control.GetCargoXKey(mov.positionKey, conex);
                    item.SubItems.Add(cargo.PositionID);
                    if ((mov.movementkey == 5 || mov.movementkey == 6))
                    {
                        var unidadNext = access.GetUnidadOrganizativaKey(mov.unidadOrgKeyDestino, conex);
                        item.SubItems.Add(unidadNext.Name);
                        var cargoNext = control.GetCargoXKey(mov.positionKeyDestino, conex);
                        item.SubItems.Add(cargoNext.PositionID);
                        
                    }
                    lvMovimientos.Items.Add(item);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar los datos seleccionados de la ausencia.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                movement = new clsMovimiento();
                var fecha =  new DateTime();
                ControllerRHSGMT001 access = new ControllerRHSGMT001();
                foreach (ListViewItem item in lvMovimientos.SelectedItems)
                {
                    fecha = Convert.ToDateTime(item.SubItems[1].Text);
                }
                var movimient = access.GetMovimiento(listaMov[0].personKey, fecha, conection);

                movement = movimient;
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar los datos de la ausencia.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LvMovimientos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                movement = new clsMovimiento();
                var fecha = new DateTime();
                ControllerRHSGMT001 access = new ControllerRHSGMT001();
                foreach (ListViewItem item in lvMovimientos.SelectedItems)
                {
                    fecha = Convert.ToDateTime(item.SubItems[1].Text);
                }
                var movimient = access.GetMovimiento(listaMov[0].personKey, fecha, conection);

                movement = movimient;
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar los datos de la ausencia.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Do_Save(object sender, EventArgs e)
        {
            try
            {
                if (lvMovimientos.SelectedItems.Count > 0)
                {
                    movement = new clsMovimiento();
                    var fecha = new DateTime();
                    ControllerRHSGMT001 access = new ControllerRHSGMT001();
                    foreach (ListViewItem item in lvMovimientos.SelectedItems)
                    {
                        fecha = Convert.ToDateTime(item.SubItems[1].Text);
                    }
                    var movimient = access.GetMovimiento(listaMov[0].personKey, fecha, conection);

                    movement = movimient;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un movimiento.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el movimiento del trabajador.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Do_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
