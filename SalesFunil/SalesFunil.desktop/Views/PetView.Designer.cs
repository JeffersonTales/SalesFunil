namespace SalesFunil.desktop {
    partial class PetView {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblPets = new Label();
            panel1 = new Panel();
            tabControlPets = new TabControl();
            tbpPetList = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            lblSearchPet = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvPetList = new DataGridView();
            tbpPetDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            lblPetColour = new Label();
            txtPetColour = new TextBox();
            lblPetType = new Label();
            txtPetType = new TextBox();
            lblPetName = new Label();
            txtPetName = new TextBox();
            lblPetID = new Label();
            txtPetID = new TextBox();
            panel1.SuspendLayout();
            tabControlPets.SuspendLayout();
            tbpPetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPetList).BeginInit();
            tbpPetDetail.SuspendLayout();
            SuspendLayout();
            // 
            // lblPets
            // 
            lblPets.AutoSize = true;
            lblPets.Location = new Point(23, 17);
            lblPets.Name = "lblPets";
            lblPets.Size = new Size(32, 15);
            lblPets.TabIndex = 0;
            lblPets.Text = "PETS";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPets);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 54);
            panel1.TabIndex = 1;
            // 
            // tabControlPets
            // 
            tabControlPets.Controls.Add(tbpPetList);
            tabControlPets.Controls.Add(tbpPetDetail);
            tabControlPets.Location = new Point(1, 61);
            tabControlPets.Name = "tabControlPets";
            tabControlPets.SelectedIndex = 0;
            tabControlPets.Size = new Size(798, 388);
            tabControlPets.TabIndex = 2;
            // 
            // tbpPetList
            // 
            tbpPetList.Controls.Add(btnDelete);
            tbpPetList.Controls.Add(btnEdit);
            tbpPetList.Controls.Add(btnAddNew);
            tbpPetList.Controls.Add(lblSearchPet);
            tbpPetList.Controls.Add(btnSearch);
            tbpPetList.Controls.Add(txtSearch);
            tbpPetList.Controls.Add(dgvPetList);
            tbpPetList.Location = new Point(4, 24);
            tbpPetList.Name = "tbpPetList";
            tbpPetList.Padding = new Padding(3);
            tbpPetList.Size = new Size(790, 360);
            tbpPetList.TabIndex = 0;
            tbpPetList.Text = "Pet list";
            tbpPetList.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(694, 122);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(694, 83);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 4;
            btnAddNew.Text = "Add new";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // lblSearchPet
            // 
            lblSearchPet.AutoSize = true;
            lblSearchPet.Location = new Point(6, 23);
            lblSearchPet.Name = "lblSearchPet";
            lblSearchPet.Size = new Size(65, 15);
            lblSearchPet.TabIndex = 3;
            lblSearchPet.Text = "Search pet:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(694, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(7, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(681, 23);
            txtSearch.TabIndex = 1;
            // 
            // dgvPetList
            // 
            dgvPetList.BorderStyle = BorderStyle.None;
            dgvPetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetList.Location = new Point(7, 70);
            dgvPetList.Name = "dgvPetList";
            dgvPetList.RowTemplate.Height = 25;
            dgvPetList.Size = new Size(681, 283);
            dgvPetList.TabIndex = 0;
            // 
            // tbpPetDetail
            // 
            tbpPetDetail.Controls.Add(btnCancel);
            tbpPetDetail.Controls.Add(btnSave);
            tbpPetDetail.Controls.Add(lblPetColour);
            tbpPetDetail.Controls.Add(txtPetColour);
            tbpPetDetail.Controls.Add(lblPetType);
            tbpPetDetail.Controls.Add(txtPetType);
            tbpPetDetail.Controls.Add(lblPetName);
            tbpPetDetail.Controls.Add(txtPetName);
            tbpPetDetail.Controls.Add(lblPetID);
            tbpPetDetail.Controls.Add(txtPetID);
            tbpPetDetail.Location = new Point(4, 24);
            tbpPetDetail.Name = "tbpPetDetail";
            tbpPetDetail.Padding = new Padding(3);
            tbpPetDetail.Size = new Size(790, 360);
            tbpPetDetail.TabIndex = 1;
            tbpPetDetail.Text = "Pet detail";
            tbpPetDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(157, 232);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(19, 232);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblPetColour
            // 
            lblPetColour.AutoSize = true;
            lblPetColour.Location = new Point(19, 155);
            lblPetColour.Name = "lblPetColour";
            lblPetColour.Size = new Size(64, 15);
            lblPetColour.TabIndex = 7;
            lblPetColour.Text = "Pet colour:";
            // 
            // txtPetColour
            // 
            txtPetColour.Location = new Point(19, 173);
            txtPetColour.Name = "txtPetColour";
            txtPetColour.Size = new Size(100, 23);
            txtPetColour.TabIndex = 6;
            // 
            // lblPetType
            // 
            lblPetType.AutoSize = true;
            lblPetType.Location = new Point(157, 90);
            lblPetType.Name = "lblPetType";
            lblPetType.Size = new Size(53, 15);
            lblPetType.TabIndex = 5;
            lblPetType.Text = "Pet type:";
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(157, 108);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(100, 23);
            txtPetType.TabIndex = 4;
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Location = new Point(19, 90);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(60, 15);
            lblPetName.TabIndex = 3;
            lblPetName.Text = "Pet name:";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(19, 108);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 23);
            txtPetName.TabIndex = 2;
            // 
            // lblPetID
            // 
            lblPetID.AutoSize = true;
            lblPetID.Location = new Point(19, 23);
            lblPetID.Name = "lblPetID";
            lblPetID.Size = new Size(41, 15);
            lblPetID.TabIndex = 1;
            lblPetID.Text = "Pet ID:";
            // 
            // txtPetID
            // 
            txtPetID.Location = new Point(19, 41);
            txtPetID.Name = "txtPetID";
            txtPetID.Size = new Size(100, 23);
            txtPetID.TabIndex = 0;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlPets);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlPets.ResumeLayout(false);
            tbpPetList.ResumeLayout(false);
            tbpPetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPetList).EndInit();
            tbpPetDetail.ResumeLayout(false);
            tbpPetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPets;
        private Panel panel1;
        private TabControl tabControlPets;
        private TabPage tbpPetList;
        private TabPage tbpPetDetail;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvPetList;
        private Label lblSearchPet;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Label lblPetName;
        private TextBox txtPetName;
        private Label lblPetID;
        private TextBox txtPetID;
        private Button btnCancel;
        private Button btnSave;
        private Label lblPetColour;
        private TextBox txtPetColour;
        private Label lblPetType;
        private TextBox txtPetType;
    }
}