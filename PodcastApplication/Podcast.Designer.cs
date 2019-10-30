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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewPodcast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonSaveCategory = new System.Windows.Forms.Button();
            this.buttonNewCatefory = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEpisode = new System.Windows.Forms.ListBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxFrekvens = new System.Windows.Forms.ComboBox();
            this.buttonDeletePodcast = new System.Windows.Forms.Button();
            this.buttonSavePodcast = new System.Windows.Forms.Button();
            this.buttonNewPodcast = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPodcast
            // 
            this.labelPodcast.AutoSize = true;
            this.labelPodcast.BackColor = System.Drawing.Color.Transparent;
            this.labelPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPodcast.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPodcast.Location = new System.Drawing.Point(25, 31);
            this.labelPodcast.Name = "labelPodcast";
            this.labelPodcast.Size = new System.Drawing.Size(214, 46);
            this.labelPodcast.TabIndex = 0;
            this.labelPodcast.Text = "PODCAST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listViewPodcast);
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
            this.panel1.Controls.Add(this.buttonNewPodcast);
            this.panel1.Controls.Add(this.labelPodcast);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 764);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(529, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Kategori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Uppdateringsfrekvens:";
            // 
            // listViewPodcast
            // 
            this.listViewPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewPodcast.HideSelection = false;
            this.listViewPodcast.Location = new System.Drawing.Point(33, 111);
            this.listViewPodcast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewPodcast.Name = "listViewPodcast";
            this.listViewPodcast.Size = new System.Drawing.Size(678, 170);
            this.listViewPodcast.TabIndex = 19;
            this.listViewPodcast.UseCompatibleStateImageBehavior = false;
            this.listViewPodcast.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Avsnitt";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namn";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.Width = 87;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(1043, 392);
            this.buttonDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(111, 45);
            this.buttonDeleteCategory.TabIndex = 18;
            this.buttonDeleteCategory.Text = "Ta bort...";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonSaveCategory
            // 
            this.buttonSaveCategory.Location = new System.Drawing.Point(896, 392);
            this.buttonSaveCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveCategory.Name = "buttonSaveCategory";
            this.buttonSaveCategory.Size = new System.Drawing.Size(111, 45);
            this.buttonSaveCategory.TabIndex = 17;
            this.buttonSaveCategory.Text = "Spara";
            this.buttonSaveCategory.UseVisualStyleBackColor = true;
            this.buttonSaveCategory.Click += new System.EventHandler(this.buttonSaveCategory_Click);
            // 
            // buttonNewCatefory
            // 
            this.buttonNewCatefory.Location = new System.Drawing.Point(748, 392);
            this.buttonNewCatefory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewCatefory.Name = "buttonNewCatefory";
            this.buttonNewCatefory.Size = new System.Drawing.Size(111, 45);
            this.buttonNewCatefory.TabIndex = 16;
            this.buttonNewCatefory.Text = "Ny...";
            this.buttonNewCatefory.UseVisualStyleBackColor = true;
            this.buttonNewCatefory.Click += new System.EventHandler(this.buttonNewCatefory_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(748, 344);
            this.textBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(406, 26);
            this.textBoxCategory.TabIndex = 15;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 20;
            this.listBoxCategory.Location = new System.Drawing.Point(748, 111);
            this.listBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(406, 164);
            this.listBoxCategory.TabIndex = 13;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(744, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kategorier:";
            // 
            // listBoxEpisode
            // 
            this.listBoxEpisode.FormattingEnabled = true;
            this.listBoxEpisode.ItemHeight = 20;
            this.listBoxEpisode.Location = new System.Drawing.Point(33, 468);
            this.listBoxEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxEpisode.Name = "listBoxEpisode";
            this.listBoxEpisode.Size = new System.Drawing.Size(678, 244);
            this.listBoxEpisode.TabIndex = 11;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(89, 344);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(221, 26);
            this.textBoxURL.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "URL:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(529, 341);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(182, 28);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged_1);
            // 
            // comboBoxFrekvens
            // 
            this.comboBoxFrekvens.FormattingEnabled = true;
            this.comboBoxFrekvens.Location = new System.Drawing.Point(327, 341);
            this.comboBoxFrekvens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFrekvens.Name = "comboBoxFrekvens";
            this.comboBoxFrekvens.Size = new System.Drawing.Size(182, 28);
            this.comboBoxFrekvens.TabIndex = 6;
            this.comboBoxFrekvens.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrekvens_SelectedIndexChanged);
            // 
            // buttonDeletePodcast
            // 
            this.buttonDeletePodcast.Location = new System.Drawing.Point(600, 392);
            this.buttonDeletePodcast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeletePodcast.Name = "buttonDeletePodcast";
            this.buttonDeletePodcast.Size = new System.Drawing.Size(111, 45);
            this.buttonDeletePodcast.TabIndex = 5;
            this.buttonDeletePodcast.Text = "Ta bort...";
            this.buttonDeletePodcast.UseVisualStyleBackColor = true;
            this.buttonDeletePodcast.Click += new System.EventHandler(this.buttonDeletePodcast_Click);
            // 
            // buttonSavePodcast
            // 
            this.buttonSavePodcast.Location = new System.Drawing.Point(464, 392);
            this.buttonSavePodcast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSavePodcast.Name = "buttonSavePodcast";
            this.buttonSavePodcast.Size = new System.Drawing.Size(111, 45);
            this.buttonSavePodcast.TabIndex = 4;
            this.buttonSavePodcast.Text = "Spara";
            this.buttonSavePodcast.UseVisualStyleBackColor = true;
            this.buttonSavePodcast.Click += new System.EventHandler(this.ButtonSavePodcast_Click);
            // 
            // buttonNewPodcast
            // 
            this.buttonNewPodcast.Location = new System.Drawing.Point(328, 392);
            this.buttonNewPodcast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNewPodcast.Name = "buttonNewPodcast";
            this.buttonNewPodcast.Size = new System.Drawing.Size(111, 45);
            this.buttonNewPodcast.TabIndex = 1;
            this.buttonNewPodcast.Text = "Ny...";
            this.buttonNewPodcast.UseVisualStyleBackColor = true;
            this.buttonNewPodcast.Click += new System.EventHandler(this.ButtonNewPodcast_Click);
            // 
            // Podcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 750);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ListView listViewPodcast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

