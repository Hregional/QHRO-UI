﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace UI
{
    public partial class RequestSurgery : Form
    {
        private ClassPatient patients = new ClassPatient();
        private ClassPHro patientsHro = new ClassPHro();
        private ClassRequestSurgery requestSurgery = new ClassRequestSurgery();
        int serviceId;
        int userId;
        public RequestSurgery(int idService, int idUser)
        {
            InitializeComponent();
            userId = idUser;
            if (idService > 0)
                serviceId = idService;
            else
                serviceId = 22;
        }
        int band = 0;
        void listPatients(string param)
        {
            DataTable infoPatientsHro = patientsHro.getPatientsByHistoryNumber(param);
            string historyNumber = "";
            int edad;

            if (textBoxSearch.Text == "Buscar paciente por No. Registro")
            {
                MessageBox.Show("Por favcor ingrese un número de registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (infoPatientsHro.Rows.Count < 1)
                {
                    MessageBox.Show("No se encuentra el numero de historia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //if (MessageBox.Show("No se encuentra el numero de historia, ¿Desea crearlo ahora mismo?", "Alerta",
                    //MessageBoxButtons.YesNo) == DialogResult.Yes)
                    //{
                    //    textBoxhistoryNumber.Enabled = false;
                    //    groupBoxpatientData.Enabled = true;
                    //    iconButtonCreateAndRequest.Visible = true;
                    //    iconButtonRequest.Visible = false;

                    //}
                }
                else
                {
                    foreach (DataRow item in infoPatientsHro.Rows)
                    {
                        historyNumber = item.Field<string>(0);
                        textBoxhistoryNumber.Text = item.Field<string>(0);
                        textBoxfirstName.Text = item.Field<string>(1);
                        textBoxsecondName.Text = item.Field<string>(2);
                        textBoxfirstSurname.Text = item.Field<string>(3);
                        textBoxsecondSurname.Text = item.Field<string>(4);
                        string sex = item.Field<string>(5);
                        if (sex == "0")
                        {
                            comboBoxGender.Text = "Masculino";
                        }
                        else if (sex == "1")
                        {
                            comboBoxGender.Text = "Femenino";
                        }
                        textBoxAge.Text = item.Field<int>(6).ToString();
                    }
                    DataTable getPatient = patients.getPatientsByHistoryNumber(historyNumber);
                    if (getPatient.Rows.Count < 1)
                    {
                        band = 1;
                    }
                    else
                    {
                        band = 2;
                        foreach (DataRow item in getPatient.Rows)
                        {
                            labelID.Text = item.Field<int>(0).ToString();

                        }
                    }
                    iconButtonRequest.Visible = true;
                    textBoxDiagnosis.Enabled = true;
                    textBoxProcedure.Enabled = true;
                }
            }
        }

        void ClearTexts()
        {
            textBoxhistoryNumber.Text = "";
            textBoxfirstName.Text = "";
            textBoxsecondName.Text = "";
            //textBoxthirdName.Text = "";
            textBoxfirstSurname.Text = "";
            textBoxsecondSurname.Text = "";
            textBoxAge.Text = "";
            textBoxDiagnosis.Text = "";
            textBoxProcedure.Text = "";
            comboBoxGender.Text = "";
            textBoxDiagnosis.Text = "";
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Buscar paciente por No. Registro")
                textBoxSearch.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                textBoxSearch.Text = "Buscar paciente por No. Registro";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            listPatients(textBoxSearch.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonRequest_Click(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text != "" && textBoxProcedure.Text != "")
            {
                if (listBox1.Items.Count > 0)
                {
                    if (band == 1)
                    {

                        List<ClassDtoDoctors> doctorsList = new List<ClassDtoDoctors>();
                        ClassDtoDoctors doctors;
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            listBox1.SelectedIndex = i;
                            doctors = new ClassDtoDoctors();
                            doctors.DoctorId = Convert.ToInt32(listBox1.SelectedItem);
                            doctorsList.Add(doctors);
                        }
                        string response = requestSurgery.makeSurgeryRequestAndPatientWithDoctors(
                            userId,
                            textBoxDiagnosis.Text,
                            textBoxProcedure.Text,
                            serviceId, 
                            textBoxhistoryNumber.Text, 
                            textBoxfirstName.Text, 
                            textBoxsecondName.Text,
                            textBoxfirstSurname.Text, 
                            textBoxsecondSurname.Text, 
                            Convert.ToInt16(textBoxAge.Text), 
                            comboBoxGender.Text, doctorsList);

                        MessageBox.Show(response);
                    }
                    else if (band == 2)
                    {
                        List<ClassDtoDoctors> doctorsList = new List<ClassDtoDoctors>();
                        ClassDtoDoctors doctors;
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            listBox1.SelectedIndex = i;
                            doctors = new ClassDtoDoctors();
                            doctors.DoctorId = Convert.ToInt32(listBox1.SelectedItem);
                            doctorsList.Add(doctors);
                        }
                        string response = requestSurgery.makeSurgeryRequest(
                            userId,
                            textBoxDiagnosis.Text,
                            textBoxProcedure.Text,
                            textBoxfirstName.Text,
                            textBoxsecondName.Text,
                            textBoxfirstSurname.Text,
                            textBoxsecondSurname.Text,
                            Convert.ToInt16(textBoxAge.Text),
                            comboBoxGender.Text,
                           Convert.ToInt32(labelID.Text),
                           serviceId,
                           doctorsList);

                        MessageBox.Show(response);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Porfavor asigne al personal médico");
                }

            }
            else
            {
                MessageBox.Show("Por favor especifique el diagnostico y procedimiento", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text != "")
            {
                iconButtonRequest.Enabled = true;
                groupBoxDocsData.Enabled = true;
            }

        }

        private void iconButtonCreateAndRequest_Click(object sender, EventArgs e)
        {
            if (textBoxDiagnosis.Text != "")
            {
                string response = requestSurgery.makeSurgeryRequestAndPatient(userId, textBoxDiagnosis.Text, serviceId, "NULL", textBoxfirstName.Text, textBoxsecondName.Text,
                textBoxfirstSurname.Text, textBoxsecondSurname.Text, Convert.ToInt16(textBoxAge.Text), comboBoxGender.Text);
                MessageBox.Show(response);
                this.Close();
            }
            else
            {
                MessageBox.Show("Porfavor llene el cambio de diagnostico");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonAddDoctor_Click(object sender, EventArgs e)
        {
            selectPerson selectP = new selectPerson(2);
            selectP.ShowDialog();
            if (selectP.id != 0)
            {
                listBox1.Items.Add(selectP.id);
                ListViewItem item = new ListViewItem(selectP.name.ToString());
                listViewDoctors.Items.Add(item);
            }
            else
            {

            }
        }

        private void iconButtonDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar al doctor?", "Confirmar",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Doctor eliminado");
                if (listViewDoctors.Items.Count > 0)
                {
                    listBox1.Items.RemoveAt(listViewDoctors.SelectedIndices[0]);
                    listViewDoctors.Items.Remove(listViewDoctors.SelectedItems[0]);

                }

            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }
    }
}
