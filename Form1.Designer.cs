namespace Kalkulator_Michal_Wesolowski
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_res_small = new System.Windows.Forms.Label();
            this.label_first = new System.Windows.Forms.Label();
            this.button_rev = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_comma = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.button_pow = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.label_Temp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_res_small
            // 
            this.label_res_small.BackColor = System.Drawing.Color.Gainsboro;
            this.label_res_small.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_res_small.Location = new System.Drawing.Point(0, 29);
            this.label_res_small.Name = "label_res_small";
            this.label_res_small.Size = new System.Drawing.Size(372, 48);
            this.label_res_small.TabIndex = 0;
            this.label_res_small.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_first
            // 
            this.label_first.BackColor = System.Drawing.Color.Gainsboro;
            this.label_first.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_first.Location = new System.Drawing.Point(0, 77);
            this.label_first.Name = "label_first";
            this.label_first.Size = new System.Drawing.Size(372, 74);
            this.label_first.TabIndex = 1;
            this.label_first.Text = "0";
            this.label_first.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_rev
            // 
            this.button_rev.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rev.Location = new System.Drawing.Point(12, 474);
            this.button_rev.Name = "button_rev";
            this.button_rev.Size = new System.Drawing.Size(75, 75);
            this.button_rev.TabIndex = 6;
            this.button_rev.Text = "+/-";
            this.button_rev.UseVisualStyleBackColor = true;
            this.button_rev.Click += new System.EventHandler(this.button_rev_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_0.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(106, 474);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(75, 75);
            this.button_0.TabIndex = 7;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_0.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_0.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_comma
            // 
            this.button_comma.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_comma.Location = new System.Drawing.Point(200, 474);
            this.button_comma.Name = "button_comma";
            this.button_comma.Size = new System.Drawing.Size(75, 75);
            this.button_comma.TabIndex = 8;
            this.button_comma.Text = ",";
            this.button_comma.UseVisualStyleBackColor = true;
            this.button_comma.Click += new System.EventHandler(this.button_comma_Click);
            // 
            // button_res
            // 
            this.button_res.BackColor = System.Drawing.Color.Lavender;
            this.button_res.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_res.Location = new System.Drawing.Point(297, 474);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(75, 75);
            this.button_res.TabIndex = 9;
            this.button_res.Text = "=";
            this.button_res.UseVisualStyleBackColor = false;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button_pow
            // 
            this.button_pow.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pow.Location = new System.Drawing.Point(12, 154);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(75, 75);
            this.button_pow.TabIndex = 13;
            this.button_pow.Text = "x^2";
            this.button_pow.UseVisualStyleBackColor = true;
            this.button_pow.Click += new System.EventHandler(this.button_pow_Click);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sub.Location = new System.Drawing.Point(297, 312);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(75, 75);
            this.button_sub.TabIndex = 17;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.Button_OperatorClick);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.Location = new System.Drawing.Point(297, 393);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 75);
            this.button_add.TabIndex = 21;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_OperatorClick);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_1.Location = new System.Drawing.Point(12, 393);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(75, 75);
            this.button_1.TabIndex = 22;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_1.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_1.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_2.Location = new System.Drawing.Point(106, 393);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(75, 75);
            this.button_2.TabIndex = 23;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_2.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_2.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_3.Location = new System.Drawing.Point(200, 393);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(75, 75);
            this.button_3.TabIndex = 24;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_3.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_3.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_4.Location = new System.Drawing.Point(11, 312);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(75, 75);
            this.button_4.TabIndex = 25;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_4.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_4.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_5.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_5.Location = new System.Drawing.Point(106, 312);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(75, 75);
            this.button_5.TabIndex = 26;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_5.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_5.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_6.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_6.Location = new System.Drawing.Point(200, 312);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(75, 75);
            this.button_6.TabIndex = 27;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_6.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_6.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_7.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_7.Location = new System.Drawing.Point(12, 231);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(75, 75);
            this.button_7.TabIndex = 28;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_7.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_7.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_8.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_8.Location = new System.Drawing.Point(106, 231);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(75, 75);
            this.button_8.TabIndex = 29;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_8.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_8.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_9.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_9.Location = new System.Drawing.Point(200, 231);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(75, 75);
            this.button_9.TabIndex = 30;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.Button_NumberClick);
            this.button_9.MouseEnter += new System.EventHandler(this.button_number_MouseEnter);
            this.button_9.MouseLeave += new System.EventHandler(this.button_number_MouseLeave);
            // 
            // button_del
            // 
            this.button_del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_del.BackgroundImage")));
            this.button_del.Location = new System.Drawing.Point(200, 154);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 75);
            this.button_del.TabIndex = 31;
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_CE
            // 
            this.button_CE.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_CE.Location = new System.Drawing.Point(106, 154);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(75, 75);
            this.button_CE.TabIndex = 32;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_div.Location = new System.Drawing.Point(297, 154);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(75, 75);
            this.button_div.TabIndex = 33;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.Button_OperatorClick);
            // 
            // button_mult
            // 
            this.button_mult.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_mult.Location = new System.Drawing.Point(297, 231);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(75, 75);
            this.button_mult.TabIndex = 34;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.Button_OperatorClick);
            // 
            // label_Temp
            // 
            this.label_Temp.AutoSize = true;
            this.label_Temp.Location = new System.Drawing.Point(175, 77);
            this.label_Temp.Name = "label_Temp";
            this.label_Temp.Size = new System.Drawing.Size(0, 13);
            this.label_Temp.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(389, 561);
            this.Controls.Add(this.label_Temp);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_pow);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_rev);
            this.Controls.Add(this.label_first);
            this.Controls.Add(this.label_res_small);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_res_small;
        private System.Windows.Forms.Label label_first;
        private System.Windows.Forms.Button button_rev;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_pow;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Label label_Temp;
    }
}

