
namespace Projet_GL_Ana_Moreira
{
    partial class JournalDeBord
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
            this.lblFest = new System.Windows.Forms.Label();
            this.lblRecommande = new System.Windows.Forms.Label();
            this.lblFav = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblTendance = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecomm = new System.Windows.Forms.Label();
            this.dgvFest = new System.Windows.Forms.DataGridView();
            this.dgvTxtFestival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatistique = new System.Windows.Forms.Label();
            this.lblNbFest = new System.Windows.Forms.Label();
            this.lblNbReservation = new System.Windows.Forms.Label();
            this.lblFestRechercher = new System.Windows.Forms.Label();
            this.lblGenreRechercher = new System.Windows.Forms.Label();
            this.txtNbFest = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.txtNbReservation = new System.Windows.Forms.TextBox();
            this.txtGenreRechercher = new System.Windows.Forms.TextBox();
            this.txtFestRechercher = new System.Windows.Forms.TextBox();
            this.btnSelection = new System.Windows.Forms.Button();
            this.dgvFav = new System.Windows.Forms.DataGridView();
            this.dgvTxtFestFav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtDateFav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtPrixFav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecomm = new System.Windows.Forms.DataGridView();
            this.dgvTxtFestRecom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtDateRecom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtPrixRecom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTendance = new System.Windows.Forms.DataGridView();
            this.dgvTxtFestTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtDateTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtPrixTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecomm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFest
            // 
            this.lblFest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFest.AutoSize = true;
            this.lblFest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFest.Location = new System.Drawing.Point(52, 24);
            this.lblFest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFest.Name = "lblFest";
            this.lblFest.Size = new System.Drawing.Size(108, 21);
            this.lblFest.TabIndex = 0;
            this.lblFest.Text = "&Vos festivales";
            this.lblFest.Click += new System.EventHandler(this.lblFest_Click);
            // 
            // lblRecommande
            // 
            this.lblRecommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecommande.AutoSize = true;
            this.lblRecommande.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecommande.Location = new System.Drawing.Point(52, 220);
            this.lblRecommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecommande.Name = "lblRecommande";
            this.lblRecommande.Size = new System.Drawing.Size(192, 21);
            this.lblRecommande.TabIndex = 4;
            this.lblRecommande.Text = "&Recommandé pour vous ";
            // 
            // lblFav
            // 
            this.lblFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFav.AutoSize = true;
            this.lblFav.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFav.Location = new System.Drawing.Point(597, 24);
            this.lblFav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(89, 21);
            this.lblFav.TabIndex = 2;
            this.lblFav.Text = "V&os favoris";
            this.lblFav.Click += new System.EventHandler(this.lblFav_Click);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(-139, -132);
            this.lblStat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(65, 15);
            this.lblStat.TabIndex = 15;
            this.lblStat.Text = "Statistique ";
            // 
            // lblTendance
            // 
            this.lblTendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTendance.AutoSize = true;
            this.lblTendance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTendance.Location = new System.Drawing.Point(597, 220);
            this.lblTendance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTendance.Name = "lblTendance";
            this.lblTendance.Size = new System.Drawing.Size(167, 21);
            this.lblTendance.TabIndex = 6;
            this.lblTendance.Text = "&Tendance de la saison";
            this.lblTendance.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView5.Location = new System.Drawing.Point(583, 554);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 82;
            this.dataGridView5.RowTemplate.Height = 41;
            this.dataGridView5.Size = new System.Drawing.Size(684, 300);
            this.dataGridView5.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Festival";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Date";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // lblRecomm
            // 
            this.lblRecomm.AutoSize = true;
            this.lblRecomm.Location = new System.Drawing.Point(583, 496);
            this.lblRecomm.Name = "lblRecomm";
            this.lblRecomm.Size = new System.Drawing.Size(281, 32);
            this.lblRecomm.TabIndex = 22;
            // 
            // dgvFest
            // 
            this.dgvFest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtFestival,
            this.dgvTxtDate,
            this.dgvTxtPrix});
            this.dgvFest.Location = new System.Drawing.Point(52, 55);
            this.dgvFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFest.Name = "dgvFest";
            this.dgvFest.RowHeadersWidth = 82;
            this.dgvFest.RowTemplate.Height = 41;
            this.dgvFest.Size = new System.Drawing.Size(436, 141);
            this.dgvFest.TabIndex = 1;
            // 
            // dgvTxtFestival
            // 
            this.dgvTxtFestival.HeaderText = "Festival";
            this.dgvTxtFestival.MinimumWidth = 8;
            this.dgvTxtFestival.Name = "dgvTxtFestival";
            this.dgvTxtFestival.Width = 150;
            // 
            // dgvTxtDate
            // 
            this.dgvTxtDate.HeaderText = "Date";
            this.dgvTxtDate.MinimumWidth = 10;
            this.dgvTxtDate.Name = "dgvTxtDate";
            // 
            // dgvTxtPrix
            // 
            this.dgvTxtPrix.HeaderText = "Prix";
            this.dgvTxtPrix.MinimumWidth = 8;
            this.dgvTxtPrix.Name = "dgvTxtPrix";
            // 
            // lblStatistique
            // 
            this.lblStatistique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatistique.AutoSize = true;
            this.lblStatistique.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatistique.Location = new System.Drawing.Point(52, 427);
            this.lblStatistique.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatistique.Name = "lblStatistique";
            this.lblStatistique.Size = new System.Drawing.Size(92, 21);
            this.lblStatistique.TabIndex = 8;
            this.lblStatistique.Text = "&Statistique ";
            // 
            // lblNbFest
            // 
            this.lblNbFest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNbFest.AutoSize = true;
            this.lblNbFest.Location = new System.Drawing.Point(52, 476);
            this.lblNbFest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbFest.Name = "lblNbFest";
            this.lblNbFest.Size = new System.Drawing.Size(107, 15);
            this.lblNbFest.TabIndex = 9;
            this.lblNbFest.Text = "&Nombre de festival";
            // 
            // lblNbReservation
            // 
            this.lblNbReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNbReservation.AutoSize = true;
            this.lblNbReservation.Location = new System.Drawing.Point(52, 508);
            this.lblNbReservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbReservation.Name = "lblNbReservation";
            this.lblNbReservation.Size = new System.Drawing.Size(134, 15);
            this.lblNbReservation.TabIndex = 11;
            this.lblNbReservation.Text = "No&mbre de Reservation ";
            // 
            // lblFestRechercher
            // 
            this.lblFestRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFestRechercher.AutoSize = true;
            this.lblFestRechercher.Location = new System.Drawing.Point(597, 476);
            this.lblFestRechercher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFestRechercher.Name = "lblFestRechercher";
            this.lblFestRechercher.Size = new System.Drawing.Size(161, 15);
            this.lblFestRechercher.TabIndex = 13;
            this.lblFestRechercher.Text = "Le festiv&ale le plus rechercher";
            this.lblFestRechercher.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblGenreRechercher
            // 
            this.lblGenreRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenreRechercher.AutoSize = true;
            this.lblGenreRechercher.Location = new System.Drawing.Point(597, 508);
            this.lblGenreRechercher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenreRechercher.Name = "lblGenreRechercher";
            this.lblGenreRechercher.Size = new System.Drawing.Size(148, 15);
            this.lblGenreRechercher.TabIndex = 15;
            this.lblGenreRechercher.Text = "Le &genre le plus rechercher";
            // 
            // txtNbFest
            // 
            this.txtNbFest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNbFest.Location = new System.Drawing.Point(228, 468);
            this.txtNbFest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNbFest.Name = "txtNbFest";
            this.txtNbFest.Size = new System.Drawing.Size(141, 23);
            this.txtNbFest.TabIndex = 10;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecherche.Location = new System.Drawing.Point(1082, 55);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(106, 26);
            this.btnRecherche.TabIndex = 18;
            this.btnRecherche.Text = "Rec&hercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // txtNbReservation
            // 
            this.txtNbReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNbReservation.Location = new System.Drawing.Point(228, 500);
            this.txtNbReservation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNbReservation.Name = "txtNbReservation";
            this.txtNbReservation.Size = new System.Drawing.Size(141, 23);
            this.txtNbReservation.TabIndex = 12;
            // 
            // txtGenreRechercher
            // 
            this.txtGenreRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenreRechercher.Location = new System.Drawing.Point(773, 500);
            this.txtGenreRechercher.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtGenreRechercher.Name = "txtGenreRechercher";
            this.txtGenreRechercher.Size = new System.Drawing.Size(141, 23);
            this.txtGenreRechercher.TabIndex = 16;
            // 
            // txtFestRechercher
            // 
            this.txtFestRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFestRechercher.Location = new System.Drawing.Point(773, 468);
            this.txtFestRechercher.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtFestRechercher.Name = "txtFestRechercher";
            this.txtFestRechercher.Size = new System.Drawing.Size(141, 23);
            this.txtFestRechercher.TabIndex = 14;
            // 
            // btnSelection
            // 
            this.btnSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelection.Location = new System.Drawing.Point(1082, 96);
            this.btnSelection.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(106, 26);
            this.btnSelection.TabIndex = 19;
            this.btnSelection.Text = "S&electionner";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFav
            // 
            this.dgvFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFav.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtFestFav,
            this.dgvTxtDateFav,
            this.dgvTxtPrixFav});
            this.dgvFav.Location = new System.Drawing.Point(597, 55);
            this.dgvFav.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvFav.Name = "dgvFav";
            this.dgvFav.RowHeadersWidth = 82;
            this.dgvFav.RowTemplate.Height = 41;
            this.dgvFav.Size = new System.Drawing.Size(436, 141);
            this.dgvFav.TabIndex = 20;
            this.dgvFav.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvTxtFestFav
            // 
            this.dgvTxtFestFav.HeaderText = "Festival";
            this.dgvTxtFestFav.MinimumWidth = 8;
            this.dgvTxtFestFav.Name = "dgvTxtFestFav";
            this.dgvTxtFestFav.Width = 150;
            // 
            // dgvTxtDateFav
            // 
            this.dgvTxtDateFav.HeaderText = "Date";
            this.dgvTxtDateFav.MinimumWidth = 10;
            this.dgvTxtDateFav.Name = "dgvTxtDateFav";
            // 
            // dgvTxtPrixFav
            // 
            this.dgvTxtPrixFav.HeaderText = "Prix";
            this.dgvTxtPrixFav.MinimumWidth = 8;
            this.dgvTxtPrixFav.Name = "dgvTxtPrixFav";
            // 
            // dgvRecomm
            // 
            this.dgvRecomm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecomm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecomm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtFestRecom,
            this.dgvTxtDateRecom,
            this.dgvTxtPrixRecom});
            this.dgvRecomm.Location = new System.Drawing.Point(52, 247);
            this.dgvRecomm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvRecomm.Name = "dgvRecomm";
            this.dgvRecomm.RowHeadersWidth = 82;
            this.dgvRecomm.RowTemplate.Height = 41;
            this.dgvRecomm.Size = new System.Drawing.Size(436, 141);
            this.dgvRecomm.TabIndex = 21;
            this.dgvRecomm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecomm_CellContentClick);
            // 
            // dgvTxtFestRecom
            // 
            this.dgvTxtFestRecom.HeaderText = "Festival";
            this.dgvTxtFestRecom.MinimumWidth = 8;
            this.dgvTxtFestRecom.Name = "dgvTxtFestRecom";
            this.dgvTxtFestRecom.Width = 150;
            // 
            // dgvTxtDateRecom
            // 
            this.dgvTxtDateRecom.HeaderText = "Date";
            this.dgvTxtDateRecom.MinimumWidth = 10;
            this.dgvTxtDateRecom.Name = "dgvTxtDateRecom";
            // 
            // dgvTxtPrixRecom
            // 
            this.dgvTxtPrixRecom.HeaderText = "Prix";
            this.dgvTxtPrixRecom.MinimumWidth = 8;
            this.dgvTxtPrixRecom.Name = "dgvTxtPrixRecom";
            // 
            // dgvTendance
            // 
            this.dgvTendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTxtFestTen,
            this.dgvTxtDateTen,
            this.dgvTxtPrixTen});
            this.dgvTendance.Location = new System.Drawing.Point(597, 247);
            this.dgvTendance.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvTendance.Name = "dgvTendance";
            this.dgvTendance.RowHeadersWidth = 82;
            this.dgvTendance.RowTemplate.Height = 41;
            this.dgvTendance.Size = new System.Drawing.Size(436, 141);
            this.dgvTendance.TabIndex = 22;
            // 
            // dgvTxtFestTen
            // 
            this.dgvTxtFestTen.HeaderText = "Festival";
            this.dgvTxtFestTen.MinimumWidth = 8;
            this.dgvTxtFestTen.Name = "dgvTxtFestTen";
            this.dgvTxtFestTen.Width = 150;
            // 
            // dgvTxtDateTen
            // 
            this.dgvTxtDateTen.HeaderText = "Date";
            this.dgvTxtDateTen.MinimumWidth = 10;
            this.dgvTxtDateTen.Name = "dgvTxtDateTen";
            // 
            // dgvTxtPrixTen
            // 
            this.dgvTxtPrixTen.HeaderText = "Prix";
            this.dgvTxtPrixTen.MinimumWidth = 8;
            this.dgvTxtPrixTen.Name = "dgvTxtPrixTen";
            // 
            // JournalDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 572);
            this.Controls.Add(this.dgvTendance);
            this.Controls.Add(this.dgvRecomm);
            this.Controls.Add(this.dgvFav);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.txtGenreRechercher);
            this.Controls.Add(this.txtFestRechercher);
            this.Controls.Add(this.txtNbReservation);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtNbFest);
            this.Controls.Add(this.lblGenreRechercher);
            this.Controls.Add(this.lblFestRechercher);
            this.Controls.Add(this.lblNbReservation);
            this.Controls.Add(this.lblNbFest);
            this.Controls.Add(this.lblStatistique);
            this.Controls.Add(this.dgvFest);
            this.Controls.Add(this.lblTendance);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.lblRecommande);
            this.Controls.Add(this.lblFav);
            this.Controls.Add(this.lblFest);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1237, 611);
            this.Name = "JournalDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal de Bord";
            this.Load += new System.EventHandler(this.JournalDeBord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecomm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFest;
        private System.Windows.Forms.Label lblRecommande;
        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label lblTendance;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label lblRecomm;
        private System.Windows.Forms.DataGridView dgvFest;
        private System.Windows.Forms.Label lblStatistique;
        private System.Windows.Forms.Label lblNbFest;
        private System.Windows.Forms.Label lblNbReservation;
        private System.Windows.Forms.Label lblFestRechercher;
        private System.Windows.Forms.Label lblGenreRechercher;
        private System.Windows.Forms.TextBox txtNbFest;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtNbReservation;
        private System.Windows.Forms.TextBox txtGenreRechercher;
        private System.Windows.Forms.TextBox txtFestRechercher;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtFestival;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPrix;
        private System.Windows.Forms.DataGridView dgvFav;
        private System.Windows.Forms.DataGridView dgvRecomm;
        private System.Windows.Forms.DataGridView dgvTendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtFestFav;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtDateFav;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPrixFav;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtFestRecom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtDateRecom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPrixRecom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtFestTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtDateTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPrixTen;
    }
}