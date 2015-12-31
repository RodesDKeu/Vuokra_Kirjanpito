namespace Vuuorka_Asunto_Kirjanpito
{
    partial class Vuokra_Kohde
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colKohdeID_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKohdeVuokralainenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKohde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOsoite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsännoitsia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVuokra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMuumaksu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.btnUusi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKohdeID_id,
            this.colKohdeVuokralainenID,
            this.colKohde,
            this.colOsoite,
            this.colIsännoitsia,
            this.colVuokra,
            this.colVesi,
            this.colMuumaksu});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(828, 214);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // colKohdeID_id
            // 
            this.colKohdeID_id.HeaderText = "Kohteen ID";
            this.colKohdeID_id.Name = "colKohdeID_id";
            this.colKohdeID_id.ReadOnly = true;
            this.colKohdeID_id.Width = 50;
            // 
            // colKohdeVuokralainenID
            // 
            this.colKohdeVuokralainenID.HeaderText = "Vuokralainen ID";
            this.colKohdeVuokralainenID.Name = "colKohdeVuokralainenID";
            this.colKohdeVuokralainenID.ReadOnly = true;
            this.colKohdeVuokralainenID.Width = 50;
            // 
            // colKohde
            // 
            this.colKohde.HeaderText = "Taloyhtiö";
            this.colKohde.Name = "colKohde";
            this.colKohde.ReadOnly = true;
            this.colKohde.Width = 150;
            // 
            // colOsoite
            // 
            this.colOsoite.HeaderText = "Osoite";
            this.colOsoite.Name = "colOsoite";
            this.colOsoite.ReadOnly = true;
            this.colOsoite.Width = 150;
            // 
            // colIsännoitsia
            // 
            this.colIsännoitsia.HeaderText = "Isännöitsiä";
            this.colIsännoitsia.Name = "colIsännoitsia";
            this.colIsännoitsia.ReadOnly = true;
            // 
            // colVuokra
            // 
            this.colVuokra.HeaderText = "Vuokra";
            this.colVuokra.Name = "colVuokra";
            this.colVuokra.ReadOnly = true;
            // 
            // colVesi
            // 
            this.colVesi.HeaderText = "Vesimaksu";
            this.colVesi.Name = "colVesi";
            this.colVesi.ReadOnly = true;
            // 
            // colMuumaksu
            // 
            this.colMuumaksu.HeaderText = "Muu maksu";
            this.colMuumaksu.Name = "colMuumaksu";
            this.colMuumaksu.ReadOnly = true;
            // 
            // btnPaivita
            // 
            this.btnPaivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivita.Location = new System.Drawing.Point(415, 195);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(89, 39);
            this.btnPaivita.TabIndex = 46;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click_1);
            // 
            // btnPoista
            // 
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(415, 156);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(89, 39);
            this.btnPoista.TabIndex = 45;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click_1);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallenna.Location = new System.Drawing.Point(415, 117);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(89, 39);
            this.btnTallenna.TabIndex = 44;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click_1);
            // 
            // btnUusi
            // 
            this.btnUusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUusi.Location = new System.Drawing.Point(415, 78);
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Size = new System.Drawing.Size(89, 39);
            this.btnUusi.TabIndex = 43;
            this.btnUusi.Text = "Uusi";
            this.btnUusi.UseVisualStyleBackColor = true;
            this.btnUusi.Click += new System.EventHandler(this.btnUusi_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Vuokralaisen ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Kohteen ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Taloyhtiö";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Osoite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Isännöitsiä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Vuokra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vesi maksu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Muu maksu";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(153, 251);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 26);
            this.textBox8.TabIndex = 32;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(153, 219);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 26);
            this.textBox7.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(153, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 26);
            this.textBox6.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(153, 155);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 26);
            this.textBox5.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(153, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 26);
            this.textBox4.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(153, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 26);
            this.textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(153, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(153, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 25;
            // 
            // Kohde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 536);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.btnUusi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Kohde";
            this.Text = "Kohde";
            this.Load += new System.EventHandler(this.Kohde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKohdeID_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKohdeVuokralainenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKohde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOsoite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsännoitsia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVuokra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuumaksu;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Button btnUusi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}