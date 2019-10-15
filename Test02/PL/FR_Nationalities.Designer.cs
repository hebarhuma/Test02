namespace Test02
{
    partial class FR_Nationalities
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
            this.DGV_Nationality = new System.Windows.Forms.DataGridView();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txt_Nationality = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rect_Nationality = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_Nationality_Prev = new System.Windows.Forms.Button();
            this.btn_Nationality_Next = new System.Windows.Forms.Button();
            this.btn_Nationalities_Save = new System.Windows.Forms.Button();
            this.btn_Nationalities_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Nationality)).BeginInit();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Nationality
            // 
            this.DGV_Nationality.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_Nationality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Nationality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Nationality.Location = new System.Drawing.Point(23, 88);
            this.DGV_Nationality.Name = "DGV_Nationality";
            this.DGV_Nationality.Size = new System.Drawing.Size(364, 218);
            this.DGV_Nationality.TabIndex = 45;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txt_Nationality);
            this.panel22.Controls.Add(this.label6);
            this.panel22.Controls.Add(this.shapeContainer2);
            this.panel22.Location = new System.Drawing.Point(18, 38);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(293, 50);
            this.panel22.TabIndex = 44;
            // 
            // txt_Nationality
            // 
            this.txt_Nationality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nationality.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nationality.Location = new System.Drawing.Point(16, 12);
            this.txt_Nationality.Multiline = true;
            this.txt_Nationality.Name = "txt_Nationality";
            this.txt_Nationality.Size = new System.Drawing.Size(205, 25);
            this.txt_Nationality.TabIndex = 3;
            this.txt_Nationality.Enter += new System.EventHandler(this.Txt_Nationality_Enter);
            this.txt_Nationality.Leave += new System.EventHandler(this.Txt_Nationality_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(227, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "الجنسية:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rect_Nationality});
            this.shapeContainer2.Size = new System.Drawing.Size(293, 50);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rect_Nationality
            // 
            this.rect_Nationality.BorderColor = System.Drawing.Color.Gainsboro;
            this.rect_Nationality.CornerRadius = 5;
            this.rect_Nationality.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rect_Nationality.Location = new System.Drawing.Point(3, 8);
            this.rect_Nationality.Name = "rect_Nationality";
            this.rect_Nationality.Size = new System.Drawing.Size(284, 31);
            // 
            // btn_Nationality_Prev
            // 
            this.btn_Nationality_Prev.BackColor = System.Drawing.Color.White;
            this.btn_Nationality_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nationality_Prev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Nationality_Prev.FlatAppearance.BorderSize = 0;
            this.btn_Nationality_Prev.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Nationality_Prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Nationality_Prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Nationality_Prev.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nationality_Prev.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Nationality_Prev.Location = new System.Drawing.Point(243, 313);
            this.btn_Nationality_Prev.Name = "btn_Nationality_Prev";
            this.btn_Nationality_Prev.Size = new System.Drawing.Size(52, 28);
            this.btn_Nationality_Prev.TabIndex = 103;
            this.btn_Nationality_Prev.Tag = "";
            this.btn_Nationality_Prev.Text = "السابق";
            this.btn_Nationality_Prev.UseVisualStyleBackColor = false;
            // 
            // btn_Nationality_Next
            // 
            this.btn_Nationality_Next.BackColor = System.Drawing.Color.White;
            this.btn_Nationality_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nationality_Next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Nationality_Next.FlatAppearance.BorderSize = 0;
            this.btn_Nationality_Next.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Nationality_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Nationality_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Nationality_Next.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nationality_Next.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Nationality_Next.Location = new System.Drawing.Point(115, 313);
            this.btn_Nationality_Next.Name = "btn_Nationality_Next";
            this.btn_Nationality_Next.Size = new System.Drawing.Size(52, 28);
            this.btn_Nationality_Next.TabIndex = 102;
            this.btn_Nationality_Next.Tag = "";
            this.btn_Nationality_Next.Text = " التالي";
            this.btn_Nationality_Next.UseVisualStyleBackColor = false;
            // 
            // btn_Nationalities_Save
            // 
            this.btn_Nationalities_Save.BackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Save.BackgroundImage = global::Test02.Properties.Resources._71880225_506727409905549_9016804364982943744_n;
            this.btn_Nationalities_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nationalities_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Nationalities_Save.FlatAppearance.BorderSize = 0;
            this.btn_Nationalities_Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nationalities_Save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nationalities_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Nationalities_Save.Location = new System.Drawing.Point(354, 46);
            this.btn_Nationalities_Save.Name = "btn_Nationalities_Save";
            this.btn_Nationalities_Save.Size = new System.Drawing.Size(33, 31);
            this.btn_Nationalities_Save.TabIndex = 105;
            this.btn_Nationalities_Save.Text = " ";
            this.btn_Nationalities_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Nationalities_Add
            // 
            this.btn_Nationalities_Add.BackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Add.BackgroundImage = global::Test02.Properties.Resources.icons8_europe_50__1_;
            this.btn_Nationalities_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Nationalities_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Nationalities_Add.FlatAppearance.BorderSize = 0;
            this.btn_Nationalities_Add.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Nationalities_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nationalities_Add.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nationalities_Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Nationalities_Add.Location = new System.Drawing.Point(315, 46);
            this.btn_Nationalities_Add.Name = "btn_Nationalities_Add";
            this.btn_Nationalities_Add.Size = new System.Drawing.Size(33, 31);
            this.btn_Nationalities_Add.TabIndex = 104;
            this.btn_Nationalities_Add.Text = " ";
            this.btn_Nationalities_Add.UseVisualStyleBackColor = false;
            // 
            // FR_Nationalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(411, 365);
            this.Controls.Add(this.btn_Nationalities_Save);
            this.Controls.Add(this.btn_Nationalities_Add);
            this.Controls.Add(this.btn_Nationality_Prev);
            this.Controls.Add(this.btn_Nationality_Next);
            this.Controls.Add(this.DGV_Nationality);
            this.Controls.Add(this.panel22);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FR_Nationalities";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الجنسيات";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Nationality)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Nationality;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Nationality;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rect_Nationality;
        private System.Windows.Forms.Button btn_Nationality_Prev;
        private System.Windows.Forms.Button btn_Nationality_Next;
        private System.Windows.Forms.Button btn_Nationalities_Save;
        private System.Windows.Forms.Button btn_Nationalities_Add;
    }
}