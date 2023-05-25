namespace Otsetki
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wklad = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.Kapitalizacja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IlLat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Stopa_o = new System.Windows.Forms.TextBox();
            this.Oblicz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Liczba Lat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wkład Własny";
            // 
            // wklad
            // 
            this.wklad.AllowDrop = true;
            this.wklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wklad.Location = new System.Drawing.Point(201, 3);
            this.wklad.Multiline = true;
            this.wklad.Name = "wklad";
            this.wklad.Size = new System.Drawing.Size(239, 55);
            this.wklad.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Odsetki";
            // 
            // Output
            // 
            this.Output.Enabled = false;
            this.Output.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Output.Location = new System.Drawing.Point(16, 381);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(179, 48);
            this.Output.TabIndex = 19;
            // 
            // Kapitalizacja
            // 
            this.Kapitalizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kapitalizacja.FormattingEnabled = true;
            this.Kapitalizacja.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "12"});
            this.Kapitalizacja.Location = new System.Drawing.Point(201, 169);
            this.Kapitalizacja.Name = "Kapitalizacja";
            this.Kapitalizacja.Size = new System.Drawing.Size(121, 39);
            this.Kapitalizacja.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 132);
            this.label3.TabIndex = 16;
            this.label3.Text = "Liczba okresów kapitalizacji w roku";
            // 
            // IlLat
            // 
            this.IlLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IlLat.FormattingEnabled = true;
            this.IlLat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.IlLat.Location = new System.Drawing.Point(201, 82);
            this.IlLat.Name = "IlLat";
            this.IlLat.Size = new System.Drawing.Size(121, 39);
            this.IlLat.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 76);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stopa procentowa";
            // 
            // Stopa_o
            // 
            this.Stopa_o.AcceptsReturn = true;
            this.Stopa_o.AcceptsTab = true;
            this.Stopa_o.AllowDrop = true;
            this.Stopa_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stopa_o.Location = new System.Drawing.Point(201, 256);
            this.Stopa_o.Multiline = true;
            this.Stopa_o.Name = "Stopa_o";
            this.Stopa_o.Size = new System.Drawing.Size(239, 70);
            this.Stopa_o.TabIndex = 22;
            // 
            // Oblicz
            // 
            this.Oblicz.AllowDrop = true;
            this.Oblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Oblicz.Location = new System.Drawing.Point(218, 332);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(128, 97);
            this.Oblicz.TabIndex = 23;
            this.Oblicz.Text = "Oblicz";
            this.Oblicz.UseVisualStyleBackColor = true;
            this.Oblicz.Click += new System.EventHandler(this.Oblicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 469);
            this.Controls.Add(this.Oblicz);
            this.Controls.Add(this.Stopa_o);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wklad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Kapitalizacja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IlLat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulator Odsetek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wklad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.ComboBox Kapitalizacja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IlLat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Stopa_o;
        private System.Windows.Forms.Button Oblicz;
    }
}

