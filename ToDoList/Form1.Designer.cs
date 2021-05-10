
namespace ToDoList
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtdo = new System.Windows.Forms.TextBox();
            this.lstdoactions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Activity";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtdo
            // 
            this.txtdo.Location = new System.Drawing.Point(306, 63);
            this.txtdo.Name = "txtdo";
            this.txtdo.Size = new System.Drawing.Size(320, 22);
            this.txtdo.TabIndex = 4;
            // 
            // lstdoactions
            // 
            this.lstdoactions.FormattingEnabled = true;
            this.lstdoactions.ItemHeight = 16;
            this.lstdoactions.Location = new System.Drawing.Point(12, 34);
            this.lstdoactions.Name = "lstdoactions";
            this.lstdoactions.Size = new System.Drawing.Size(288, 388);
            this.lstdoactions.TabIndex = 5;
            this.lstdoactions.SelectedIndexChanged += new System.EventHandler(this.lstdoactions_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDoList.Properties.Resources.monaco_3840x2160_principality_city_twilight_night_sky_light_boats_848;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.lstdoactions);
            this.Controls.Add(this.txtdo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtdo;
        private System.Windows.Forms.ListBox lstdoactions;
    }
}

