namespace PodcastApplication
{
    partial class Podcast
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
            this.labelPodcast = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEpisode = new System.Windows.Forms.ListBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxFrekvens = new System.Windows.Forms.ComboBox();
            this.buttonDeletePodcast = new System.Windows.Forms.Button();
            this.buttonSavePodcast = new System.Windows.Forms.Button();
            this.listBoxPodcast = new System.Windows.Forms.ListBox();
            this.buttonNewPodcast = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonSaveCategory = new System.Windows.Forms.Button();
            this.buttonNewCatefory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPodcast
            // 
            this.labelPodcast.AutoSize = true;
            this.labelPodcast.BackColor = System.Drawing.Color.Transparent;
            this.labelPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPodcast.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPodcast.Location = new System.Drawing.Point(22, 25);
            this.labelPodcast.Name = "labelPodcast";
            this.labelPodcast.Size = new System.Drawing.Size(183, 39);
            this.labelPodcast.TabIndex = 0;
            this.labelPodcast.Text = "PODCAST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.buttonDeleteCategory);
            this.panel1.Controls.Add(this.buttonSaveCategory);
            this.panel1.Controls.Add(this.buttonNewCatefory);
            this.panel1.Controls.Add(this.textBoxCategory);
            this.panel1.Controls.Add(this.listBoxCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBoxEpisode);
            this.panel1.Controls.Add(this.textBoxURL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.comboBoxFrekvens);
            this.panel1.Controls.Add(this.buttonDeletePodcast);
            this.panel1.Controls.Add(this.buttonSavePodcast);
            this.panel1.Controls.Add(this.listBoxPodcast);
            this.panel1.Controls.Add(this.buttonNewPodcast);
            this.panel1.Controls.Add(this.labelPodcast);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 611);
            this.panel1.TabIndex = 1;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 16;
            this.listBoxCategory.Location = new System.Drawing.Point(665, 89);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(361, 164);
            this.listBoxCategory.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(661, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kategorier:";
            // 
            // listBoxEpisode
            // 
            this.listBoxEpisode.FormattingEnabled = true;
            this.listBoxEpisode.ItemHeight = 16;
            this.listBoxEpisode.Location = new System.Drawing.Point(29, 374);
            this.listBoxEpisode.Name = "listBoxEpisode";
            this.listBoxEpisode.Size = new System.Drawing.Size(603, 196);
            this.listBoxEpisode.TabIndex = 11;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(79, 275);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(197, 22);
            this.textBoxURL.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "URL:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(470, 273);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(162, 24);
            this.comboBoxCategory.TabIndex = 7;
            // 
            // comboBoxFrekvens
            // 
            this.comboBoxFrekvens.FormattingEnabled = true;
            this.comboBoxFrekvens.Location = new System.Drawing.Point(291, 273);
            this.comboBoxFrekvens.Name = "comboBoxFrekvens";
            this.comboBoxFrekvens.Size = new System.Drawing.Size(162, 24);
            this.comboBoxFrekvens.TabIndex = 6;
            // 
            // buttonDeletePodcast
            // 
            this.buttonDeletePodcast.Location = new System.Drawing.Point(533, 314);
            this.buttonDeletePodcast.Name = "buttonDeletePodcast";
            this.buttonDeletePodcast.Size = new System.Drawing.Size(99, 36);
            this.buttonDeletePodcast.TabIndex = 5;
            this.buttonDeletePodcast.Text = "Ta bort...";
            this.buttonDeletePodcast.UseVisualStyleBackColor = true;
            // 
            // buttonSavePodcast
            // 
            this.buttonSavePodcast.Location = new System.Drawing.Point(412, 314);
            this.buttonSavePodcast.Name = "buttonSavePodcast";
            this.buttonSavePodcast.Size = new System.Drawing.Size(99, 36);
            this.buttonSavePodcast.TabIndex = 4;
            this.buttonSavePodcast.Text = "Spara";
            this.buttonSavePodcast.UseVisualStyleBackColor = true;
            // 
            // listBoxPodcast
            // 
            this.listBoxPodcast.FormattingEnabled = true;
            this.listBoxPodcast.ItemHeight = 16;
            this.listBoxPodcast.Location = new System.Drawing.Point(29, 89);
            this.listBoxPodcast.Name = "listBoxPodcast";
            this.listBoxPodcast.Size = new System.Drawing.Size(603, 164);
            this.listBoxPodcast.TabIndex = 2;
            // 
            // buttonNewPodcast
            // 
            this.buttonNewPodcast.Location = new System.Drawing.Point(292, 314);
            this.buttonNewPodcast.Name = "buttonNewPodcast";
            this.buttonNewPodcast.Size = new System.Drawing.Size(99, 36);
            this.buttonNewPodcast.TabIndex = 1;
            this.buttonNewPodcast.Text = "Ny...";
            this.buttonNewPodcast.UseVisualStyleBackColor = true;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(665, 275);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(361, 22);
            this.textBoxCategory.TabIndex = 15;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(917, 314);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(99, 36);
            this.buttonDeleteCategory.TabIndex = 18;
            this.buttonDeleteCategory.Text = "Ta bort...";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCategory
            // 
            this.buttonSaveCategory.Location = new System.Drawing.Point(796, 314);
            this.buttonSaveCategory.Name = "buttonSaveCategory";
            this.buttonSaveCategory.Size = new System.Drawing.Size(99, 36);
            this.buttonSaveCategory.TabIndex = 17;
            this.buttonSaveCategory.Text = "Spara";
            this.buttonSaveCategory.UseVisualStyleBackColor = true;
            // 
            // buttonNewCatefory
            // 
            this.buttonNewCatefory.Location = new System.Drawing.Point(676, 314);
            this.buttonNewCatefory.Name = "buttonNewCatefory";
            this.buttonNewCatefory.Size = new System.Drawing.Size(99, 36);
            this.buttonNewCatefory.TabIndex = 16;
            this.buttonNewCatefory.Text = "Ny...";
            this.buttonNewCatefory.UseVisualStyleBackColor = true;
            // 
            // Podcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 600);
            this.Controls.Add(this.panel1);
            this.Name = "Podcast";
            this.Text = "Podcast Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPodcast;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxFrekvens;
        private System.Windows.Forms.Button buttonDeletePodcast;
        private System.Windows.Forms.Button buttonSavePodcast;
        private System.Windows.Forms.ListBox listBoxPodcast;
        private System.Windows.Forms.Button buttonNewPodcast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.ListBox listBoxEpisode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonSaveCategory;
        private System.Windows.Forms.Button buttonNewCatefory;
    }
}

