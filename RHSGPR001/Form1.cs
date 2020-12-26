using Entidades.RHSGMT001;
using Negocio;
using Net4Sage;
using Net4Sage.Controls;
using RHSGPR001;
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

namespace RHSGMT001
{
    public partial class frmGestionMovimientoTrabajador : Form
    {
        Sage500AppEntities mycontext;
        ThrPeople person;
        ControllerRHSGMT001 controler;
        List<clsMovimiento> listaMovimientos;
        ThrOperationsPeriod periodo;
        ControllerRHSMC001 controller;      
        string conection;
        public frmGestionMovimientoTrabajador()
        {
            InitializeComponent();
        }
        public frmGestionMovimientoTrabajador(ref SageSession session) : this()
        {            
            this.sageSession1.InitializeSession(session);
            person = new ThrPeople();
            controler = new ControllerRHSGMT001();
            controller = new ControllerRHSMC001();
            listaMovimientos = new List<clsMovimiento>();
            LoadContext();
            CargarDatosIniciales();
            DisableControls();

        }
        public void LoadContext()
        {
            System.Data.EntityClient.EntityConnectionStringBuilder connectionString = new System.Data.EntityClient.EntityConnectionStringBuilder()
            {
                Metadata = "res://*/DataModel1.csdl|res://*/DataModel1.ssdl|res://*/DataModel1.msl",
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = sageSession1.GetConnectionString()
            };
            conection = connectionString.ToString();
            mycontext = new Sage500AppEntities(connectionString.ToString());
        }
        public void CargarDatosIniciales()
        {
            ControllerRHSMGP001 open = new ControllerRHSMGP001();
            periodo = open.GetPeriodoActivo(conection);
            if (periodo != null)
            {
                lblPeriodoActivo.Text = periodo.PeriodFechaInicio.ToShortDateString() + " " + "-" + " " + periodo.PeriodFechaFin.ToShortDateString();
                cmbmovimiento.DataSource = controler.GetTiposMovimientos(conection);
                cmbmovimiento.DisplayMember = "MovementName";
                cmbmovimiento.ValueMember = "Movementkey";
                cmbmovimiento.Text = "Traslado";

                ControllerRHSGI001 controller = new ControllerRHSGI001();
                cmbUnidadOrganizativas.DataSource = controller.GetaAllsUnidadesAdministrativas(conection);
                cmbUnidadOrganizativas.DisplayMember = "Name";
                cmbUnidadOrganizativas.ValueMember = "OrgUnitKey";

                cmbUnidadReubicacion.DataSource = controller.GetaAllsUnidadesAdministrativas(conection);
                cmbUnidadReubicacion.DisplayMember = "Name";
                cmbUnidadReubicacion.ValueMember = "OrgUnitKey";

            }
            else
            {
                MessageBox.Show("No existe un periodo abierto para gestionar movimientos a Tabajadores.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableControls();                
            }

        }       
        private void OnNavChange(object sender, Net4Sage.Controls.Lookup.LookupReturnEventArgs eventArgs)
        {
            person = eventArgs.ReturnValue as ThrPeople;
            try
            {
                if (person != null)
                {
                    MostrarPersonasSeleccionadas(person);                    
                }
                else
                {
                    int estado = 6;
                    ControlllerRHSMP001 controler = new ControlllerRHSMP001();
                    person = controler.GetPersona(txtCI.Text,conection);
                    MostrarPersonasSeleccionadas(person);                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableControls()
        {
            grbDatosMovimiento.Enabled = true;
            grbtraslado.Enabled = true;
        }
        private void DisableControls()
        {
            grbDatosMovimiento.Enabled = false;
            grbtraslado.Enabled = false;
        }
        private void Form_Show(object sender, EventArgs e)
        {
            UpdateLookup();
            DisableControls();
        }
        private void UpdateLookup()
        {
            ControlllerRHSMP001 controler = new ControlllerRHSMP001();            
            lkuNav.SetData(controler.DevolverTodos(conection));            
        }
        private void Cmbmovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grbDatosMovimiento.Enabled == true)
            {
                if (cmbmovimiento.Text == "Traslado")
                {
                    grbtraslado.Visible = true;
                    grbAlta.Visible = false;
                    grbBaja.Visible = false;
                    grbReubicacion.Visible = false;
                }
                if (cmbmovimiento.Text == "Alta")
                {
                    grbtraslado.Visible = false;
                    grbAlta.Visible = true;
                    grbBaja.Visible = false;
                    grbReubicacion.Visible = false;
                }
                if (cmbmovimiento.Text == "Baja")
                {
                    grbtraslado.Visible = false;
                    grbAlta.Visible = false;
                    grbBaja.Visible = true;
                    grbReubicacion.Visible = false;
                }
                if (cmbmovimiento.Text == "Reubicación")
                {
                    grbtraslado.Visible = false;
                    grbAlta.Visible = false;
                    grbBaja.Visible = false;
                    grbReubicacion.Visible = true;
                }
            }
        }         
        public void MostrarPersonasSeleccionadas(ThrPeople persona)
        {
            if (persona!=null)
            {               
                lbldatosPersona.Text = persona.PrimerNombre + " " + persona.SegundoNombre + " " + persona.PrimerApellido + " " + persona.SegundoApellido;
                txtCI.Text = person.CI.ToString();
                chkcrearMovimiento.Enabled = true;
                MostrarDatosPersona(persona);
                CargarMovimientosTrabajador();
            }            
        }
        public void MostrarDatosPersona(ThrPeople person)
        {
            try
            {
                ControllerRHSMUO001 controler = new ControllerRHSMUO001();
                var Unidad = controler.GetUnidadOrganizativaKey(person.OrgUnitKey, conection);                
                var position = controller.GetCargoXKey(person.PositionKey, conection);
                txtUnidadOrganizativa.Text = Unidad.Name;
                txtUnidadOrgReubicacion.Text = Unidad.Name;
                txtCargo.Text = position.PositionID;
                txtCargoReubicacion.Text = position.PositionID;
                CmbUnidadOrganizativas_SelectionChangeCommitted(null, null);
                if (person.Estato == 2)
                {
                    txtEstado.Text = "Baja";
                }
                else if (person.Estato == 5)
                { txtEstado.Text = "Solicitud"; }
                else 
                { txtEstado.Text = "Alta"; }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos del trabajador seleccionado.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarMovimientosTrabajador()
        {
            listaMovimientos = controler.GetMovimientosTrabajador(person, periodo.Periodkey, conection);
            if (listaMovimientos.Count > 0)
            { btnDetalles.Visible = true; }
        }
        public void CargarDatosMovimiento(clsMovimiento movimiento)
        {
            if (movimiento != null)
            {                
                if (movimiento.movementkey == 3)
                {
                    //alta
                    chkcrearMovimiento.Checked = true;
                    grbDatosMovimiento.Enabled = true;
                    grbBaja.Visible = false;
                    grbtraslado.Visible = false;
                    grbAlta.Visible = true;
                    dtpfechaAlta.Text = movimiento.fechaMovement.ToString();
                    cmbmovimiento.Text = "Alta";

                }
                if (movimiento.movementkey == 4)
                { // baja
                    chkcrearMovimiento.Checked = true;
                    grbDatosMovimiento.Enabled = true;
                    grbBaja.Visible = true;
                    grbtraslado.Visible = false;
                    grbAlta.Visible = false;
                    dtpFechaBaja.Text = movimiento.fechaMovement.ToString();
                    cmbmovimiento.Text = "Baja";
                }
                if (movimiento.movementkey == 5)
                {
                    //TRaslado
                    chkcrearMovimiento.Checked = true;
                    grbDatosMovimiento.Enabled = true;
                    grbBaja.Visible = false;
                    grbtraslado.Visible = true;
                    grbAlta.Visible = false;
                    ControllerRHSMC001 control = new ControllerRHSMC001();
                    var position = control.GetCargoXKey(movimiento.positionKey, conection);
                    txtCargo.Text = position.PositionID;
                    ControllerRHSMUO001 access = new ControllerRHSMUO001();
                    var unidad = access.GetUnidadOrganizativaKey(movimiento.unidadOrgKey, conection);
                    txtUnidadOrganizativa.Text = unidad.Name;
                    dtpFechaMovimiento.Text = movimiento.fechaMovement.ToString();
                    txtCausa.Text = movimiento.causa;
                    var positionNext = control.GetCargoXKey(movimiento.positionKeyDestino, conection);
                    cmbCargo.Text = positionNext.PositionID;
                    var unidadNext = access.GetUnidadOrganizativaKey(movimiento.unidadOrgKeyDestino, conection);
                    cmbUnidadOrganizativas.Text = unidadNext.Name;
                    cmbmovimiento.Text = "Traslado";
                }
                if (movimiento.movementkey == 6)
                {
                    chkcrearMovimiento.Checked = true;
                    grbDatosMovimiento.Enabled = true;
                    grbBaja.Visible = false;
                    grbtraslado.Visible = true;
                    grbAlta.Visible = false;
                    ControllerRHSMC001 control = new ControllerRHSMC001();
                    var position = control.GetCargoXKey(movimiento.positionKey, conection);
                    txtCargoReubicacion.Text = position.PositionID;
                    ControllerRHSMUO001 access = new ControllerRHSMUO001();
                    var unidad = access.GetUnidadOrganizativaKey(movimiento.unidadOrgKey, conection);
                    txtUnidadOrgReubicacion.Text = unidad.Name;
                    dtFechaMoviminetoReubicacion.Text = movimiento.fechaMovement.ToString();
                    txtCausaReubicacion.Text = movimiento.causa;
                    var positionNext = control.GetCargoXKey(movimiento.positionKeyDestino, conection);
                    cmbCargoReubicacion.Text = positionNext.PositionID;
                    var unidadNext = access.GetUnidadOrganizativaKey(movimiento.unidadOrgKeyDestino, conection);
                    cmbUnidadReubicacion.Text = unidadNext.Name;
                    cmbmovimiento.Text = "Reubicación";
                }
                starBar.SetFormStatus(FormBindingStatus.Editing);
            }
           
        }
        private void TxtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ControlllerRHSMP001 controler = new ControlllerRHSMP001();
                person = controler.GetPersona(txtCI.Text,conection);               
                MostrarPersonasSeleccionadas(person);
                txtCI.Clear();                
            }
        }        
        private void CmbUnidadOrganizativas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbCargo.DataSource = controller.GetAllCargosxUnidad(Convert.ToInt16(cmbUnidadOrganizativas.SelectedValue), conection);
            cmbCargo.DisplayMember = "PositionID";
            cmbCargo.ValueMember = "PositionKey";

            cmbCargoReubicacion.DataSource = controller.GetAllCargosxUnidad(Convert.ToInt16(cmbUnidadOrganizativas.SelectedValue), conection);
            cmbCargoReubicacion.DisplayMember = "PositionID";
            cmbCargoReubicacion.ValueMember = "PositionKey";

        }
        private void Do_Save(object sender, EventArgs e)
        {
            clsMovimiento movement;
            
            if (cmbmovimiento.Text == "Traslado")
            {
                if (txtEstado.Text == "Alta")
                {
                    if (dtpFechaMovimiento.Value >= periodo.PeriodFechaInicio && dtpFechaMovimiento.Value <= periodo.PeriodFechaFin)
                    {
                        if (txtCausa.Text != "")
                        {
                            if ((cmbUnidadOrganizativas.Text != txtUnidadOrganizativa.Text) || (cmbCargo.Text != txtCargo.Text))
                            {
                                movement = new clsMovimiento();
                                movement.fechaMovement = Convert.ToDateTime(dtpFechaMovimiento.Text);
                                movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                                movement.personKey = person.PersonKey;
                                movement.unidadOrgKey = person.OrgUnitKey;
                                movement.positionKey = person.PositionKey;
                                movement.causa = txtCausa.Text;
                                movement.unidadOrgKeyDestino = Convert.ToInt32(cmbUnidadOrganizativas.SelectedValue);
                                movement.positionKeyDestino = Convert.ToInt32(cmbCargo.SelectedValue);
                                movement.periodo = periodo.Periodkey;
                                controler.AddMovementTrasladoReubicacion(movement, conection);
                                CargarMovimientosTrabajador();
                            }
                            else
                            { MessageBox.Show("Verifique, el traslado continen datos erróneos.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        else
                        { MessageBox.Show("Verifique, el campo Causa es obligatorio.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    { MessageBox.Show("Verifique, la fecha de movimiento seleccionada no se encuentra dentro del período activo.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                { MessageBox.Show("Verifique, el estado actual de la persona no permite realizar ese Tipo de Movimiento.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                       
            }
            if (cmbmovimiento.Text == "Alta")
            {

                if ((txtEstado.Text == "Baja") || (txtEstado.Text == "Solicitud"))
                {
                    if (dtpfechaAlta.Value >= periodo.PeriodFechaInicio && dtpfechaAlta.Value <= periodo.PeriodFechaFin)
                    {

                        movement = new clsMovimiento();
                        movement.fechaMovement = Convert.ToDateTime(dtpfechaAlta.Text);
                        movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                        movement.personKey = person.PersonKey;
                        movement.unidadOrgKey = person.OrgUnitKey;
                        movement.positionKey = person.PositionKey;
                        movement.periodo = periodo.Periodkey;
                        controler.AddMovementAltaBaja(movement, conection);
                        CargarMovimientosTrabajador();
                    }
                    else
                    { MessageBox.Show("Verifique, la fecha de movimiento seleccionada no se encuentra dentro del período activo.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                { MessageBox.Show("Verifique, el estado actual de la persona no permite realizar ese Tipo de Movimiento.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            if (cmbmovimiento.Text == "Baja")
            {
                if (txtEstado.Text == "Alta")
                {
                    if (dtpFechaBaja.Value >= periodo.PeriodFechaInicio && dtpFechaBaja.Value <= periodo.PeriodFechaFin)
                    {
                        movement = new clsMovimiento();
                        movement.fechaMovement = Convert.ToDateTime(dtpFechaBaja.Text);
                        movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                        movement.personKey = person.PersonKey;
                        movement.unidadOrgKey = person.OrgUnitKey;
                        movement.positionKey = person.PositionKey;
                        movement.periodo = periodo.Periodkey;
                        controler.AddMovementAltaBaja(movement, conection);
                        CargarMovimientosTrabajador();
                    }
                    else
                    { MessageBox.Show("Verifique, la fecha de movimiento seleccionada no se encuentra dentro del período activo.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                { MessageBox.Show("Verifique, el estado actual de la persona no permite realizar ese Tipo de Movimiento.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            }
            if (cmbmovimiento.Text == "Reubicación")
            {
                if (txtEstado.Text == "Alta")
                {
                    if (dtFechaMoviminetoReubicacion.Value >= periodo.PeriodFechaInicio && dtFechaMoviminetoReubicacion.Value <= periodo.PeriodFechaFin)
                    {
                        if (txtCausaReubicacion.Text != "")
                        {
                            if ((cmbUnidadReubicacion.Text != txtUnidadOrgReubicacion.Text) || (cmbCargoReubicacion.Text != txtCargoReubicacion.Text))
                            {
                                movement = new clsMovimiento();
                                movement.fechaMovement = Convert.ToDateTime(dtFechaMoviminetoReubicacion.Text);
                                movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                                movement.personKey = person.PersonKey;
                                movement.unidadOrgKey = person.OrgUnitKey;
                                movement.positionKey = person.PositionKey;
                                movement.causa = txtCausaReubicacion.Text;
                                movement.unidadOrgKeyDestino = Convert.ToInt32(cmbUnidadReubicacion.SelectedValue);
                                movement.positionKeyDestino = Convert.ToInt32(cmbCargoReubicacion.SelectedValue);
                                movement.periodo = periodo.Periodkey;
                                controler.AddMovementTrasladoReubicacion(movement, conection);
                                CargarMovimientosTrabajador();
                            }
                            else
                            { MessageBox.Show("Verifique, el traslado continen datos erróneos.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        else
                        { MessageBox.Show("Verifique, el campo Causa es obligatorio.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    { MessageBox.Show("Verifique, el estado actual de la persona no permite realizar ese Tipo de Movimiento.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                { MessageBox.Show("Verifique, la fecha de movimiento seleccionada no se encuentra dentro del período activo.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            UpdateLookup();

        }       
        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbldatosPersona.Text != "")
                {
                    clsMovimiento mov;
                    frmMovimientos formMovimientos = new frmMovimientos(listaMovimientos, conection);
                    if (formMovimientos.ShowDialog() == DialogResult.OK)
                    {
                        mov = formMovimientos.movement;
                        if (mov != null)
                        {
                            CargarDatosMovimiento(mov);
                        }
                    }

                }
                else { MessageBox.Show("Debe seleccionar la persona que desea procesar.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception)
            {
                MessageBox.Show("Error cargando los movimientos del trabajador.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            

        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcrearMovimiento.Checked == true)
            {
                EnableControls();
                starBar.SetFormStatus(FormBindingStatus.Adding);
            }
            else { DisableControls(); }
        }
        private void Do_Cancel(object sender, EventArgs e)
        {
            lbldatosPersona.Text = "";
            btnDetalles.Visible = false;
            txtCI.Text = "";
            txtEstado.Text = "";
            chkcrearMovimiento.Checked = false;
            txtCausa.Text = "";
            dtpFechaMovimiento.Value = DateTime.Now;
            dtpfechaAlta.Value = DateTime.Now;
            dtpFechaBaja.Value = DateTime.Now;
            grbtraslado.Visible = true;
            grbBaja.Visible = false;
            grbAlta.Visible = false;
            grbReubicacion.Visible = false;
            cmbmovimiento.Text = "Traslado";
            cmbUnidadOrganizativas.SelectedIndex = 0;
            cmbCargo.SelectedIndex = 0;
            starBar.SetFormStatus(FormBindingStatus.None);
            chkcrearMovimiento.Enabled = false;
            DisableControls();
        }
        private bool Do_Delete(object sender, EventArgs e)
        {
            try
            {
                bool resultadoFinal = false;
                if (cmbmovimiento.Text == "Traslado")
                {
                    var movement = new clsMovimiento();
                    movement.fechaMovement = Convert.ToDateTime(dtpFechaMovimiento.Text);
                    movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                    movement.personKey = person.PersonKey;
                    movement.periodo = periodo.Periodkey;
                    resultadoFinal = controler.EliminarMovimiento(movement, conection);
                }
                if (cmbmovimiento.Text == "Reubicación")
                {
                    var movement = new clsMovimiento();
                    movement.fechaMovement = Convert.ToDateTime(dtFechaMoviminetoReubicacion.Text);
                    movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                    movement.personKey = person.PersonKey;
                    movement.periodo = periodo.Periodkey;
                    resultadoFinal = controler.EliminarMovimiento(movement, conection);
                }
                if (cmbmovimiento.Text == "Alta")
                {
                    var movement = new clsMovimiento();
                    movement.fechaMovement = Convert.ToDateTime(dtpfechaAlta.Text);
                    movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                    movement.personKey = person.PersonKey;
                    movement.periodo = periodo.Periodkey;
                    resultadoFinal = controler.EliminarMovimiento(movement, conection);
                }
                if (cmbmovimiento.Text == "Baja")
                {
                    var movement = new clsMovimiento();
                    movement.fechaMovement = Convert.ToDateTime(dtpFechaBaja.Text);
                    movement.movementkey = Convert.ToInt32(cmbmovimiento.SelectedValue);
                    movement.personKey = person.PersonKey;
                    movement.periodo = periodo.Periodkey;
                    resultadoFinal = controler.EliminarMovimiento(movement, conection);
                }
                if (resultadoFinal)
                {
                    MessageBox.Show("Registro de movimiento del trabajador eliminado satisfactoriamente.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Verifique, el registro que desea eliminar no existe.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return resultadoFinal;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el registro requerido.", "Sage MAS 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }
    }
}
