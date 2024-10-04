﻿namespace BookManager
{
    partial class frmBookManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookManagement));
            panel1 = new Panel();
            label3 = new Label();
            picBoxLogo = new PictureBox();
            panel2 = new Panel();
            btnBack = new Button();
            btnRemoveBook = new Button();
            btnUpdateBook = new Button();
            btnCreateBook = new Button();
            dgvBookList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(picBoxLogo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 81);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 48F);
            label3.Location = new Point(86, 0);
            label3.Name = "label3";
            label3.Size = new Size(534, 79);
            label3.TabIndex = 21;
            label3.Text = "Book Management";
            // 
            // picBoxLogo
            // 
            picBoxLogo.BackColor = Color.Black;
            picBoxLogo.BackgroundImageLayout = ImageLayout.None;
            picBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            picBoxLogo.Image = Properties.Resources.MythLogo;
            picBoxLogo.Location = new Point(0, 0);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(80, 80);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 20;
            picBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnRemoveBook);
            panel2.Controls.Add(btnUpdateBook);
            panel2.Controls.Add(btnCreateBook);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 449);
            panel2.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Dock = DockStyle.Bottom;
            btnBack.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(0, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 36);
            btnBack.TabIndex = 4;
            btnBack.Text = "Go back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBook
            // 
            btnRemoveBook.AutoSize = true;
            btnRemoveBook.Dock = DockStyle.Top;
            btnRemoveBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveBook.ForeColor = Color.Black;
            btnRemoveBook.Location = new Point(0, 72);
            btnRemoveBook.Name = "btnRemoveBook";
            btnRemoveBook.Size = new Size(158, 36);
            btnRemoveBook.TabIndex = 3;
            btnRemoveBook.Text = "Remove a Book";
            btnRemoveBook.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.AutoSize = true;
            btnUpdateBook.Dock = DockStyle.Top;
            btnUpdateBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateBook.ForeColor = Color.Black;
            btnUpdateBook.Location = new Point(0, 36);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(158, 36);
            btnUpdateBook.TabIndex = 1;
            btnUpdateBook.Text = "Update a Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnCreateBook
            // 
            btnCreateBook.AutoSize = true;
            btnCreateBook.Dock = DockStyle.Top;
            btnCreateBook.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateBook.ForeColor = Color.Black;
            btnCreateBook.Location = new Point(0, 0);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(158, 36);
            btnCreateBook.TabIndex = 0;
            btnCreateBook.Text = "Create a Book";
            btnCreateBook.UseVisualStyleBackColor = true;
            // 
            // dgvBookList
            // 
            dgvBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBookList.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookList.ColumnHeadersHeight = 30;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBookList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBookList.Dock = DockStyle.Fill;
            dgvBookList.GridColor = Color.Black;
            dgvBookList.Location = new Point(158, 81);
            dgvBookList.Name = "dgvBookList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBookList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvBookList.Size = new Size(964, 449);
            dgvBookList.TabIndex = 4;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 530);
            Controls.Add(dgvBookList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMember";
            Text = "Book Management";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private PictureBox picBoxLogo;
        private Panel panel2;
        private DataGridView dgvBookList;
        private Button btnRemoveBook;
        private Button btnUpdateBook;
        private Button btnCreateBook;
        private Button btnBack;
    }
}