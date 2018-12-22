﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A19_Nadav_308426048_David_311338016
{
    public partial class DataLoggingForm : Form
    {
        //TODO: why we need set here
        public FacebookAppManager FacebookAppManager { get; set; }
        private DateTime m_FormCreatingTime;

        public DataLoggingForm()
        {
            FacebookAppManager = FacebookAppManager.GetFacebookManagerInstance();
            m_FormCreatingTime = DateTime.Now;
            InitializeComponent();
        }

        private void DataLoggingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            insertToDatabase();
        }

        protected void insertToDatabase()
        {
            string formName = GetType().Name;
            DateTime formClosingTime = DateTime.Now;
            TimeSpan timeSpentOnForm = formClosingTime.Subtract(m_FormCreatingTime);

            string closingTimeMySql = convertToMySqlDate(formClosingTime);
            string creatingTimeMySql = convertToMySqlDate(m_FormCreatingTime);
            string insertCommand = string.Format("insert into FormsActivitiesLog (form_name, form_creating_time, form_closing_time, duration_time) values ('{0}', '{1}', '{2}', '{3}')", formName, creatingTimeMySql, closingTimeMySql, timeSpentOnForm);
            new Thread(() => DataBaseConnection.InsertIntoDataBase(insertCommand)).Start();
        }

        private string convertToMySqlDate(DateTime i_DateTime)
        {
            return i_DateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}