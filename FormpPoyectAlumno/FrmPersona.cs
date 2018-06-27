using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace FormpPoyectAlumno
{
   
    public partial class FrmDatos : Form
    {
       
        public FrmDatos()
        {
            InitializeComponent();
            
        }

        public void btnSave_Click_1(object sender, EventArgs e)
        {
            Persona person = new Persona
            {
                intId = Convert.ToInt32(txtId.Text),
                StrName = txtName.Text,
                StrSurname = txtSurname.Text,
                strDNI = txtDNI.Text
            };
            
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtDNI.Clear();
            var addpersona = new PersonaFileManager();
            addpersona.Add(person);



        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
