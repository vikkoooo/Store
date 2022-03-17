﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGB07_viktlund104_Laboration4_Store
{
	public partial class MainForm : Form
	{
		private FileHandler db;
		private BindingSource storeSource;
		
		public MainForm()
		{
			InitializeComponent();
			
			// Initialize our FileHandling
			db = new FileHandler();
			//db.LoadFile();

			storeSource = new BindingSource();
//			storeSource.DataSource = d


		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Add StockControl to stock tab in MainForm
			StockControl stock = new StockControl();
			stockTab.Dock = DockStyle.Fill;
			stockTab.Controls.Add(stock);
			
			// Add SalesControl to sales tab in MainForm
			SalesControl sales = new SalesControl();
			salesTab.Dock = DockStyle.Fill;
			salesTab.Controls.Add(sales);
		}
	}
}