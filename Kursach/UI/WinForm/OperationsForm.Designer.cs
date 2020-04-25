namespace Kursach.UI.WinForm
{
    partial class OperationsForm
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.workTeamGUIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.typeOperationsGUIDDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.nameOperationsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.typeOperationsGUIDLookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.workTeamGUIDDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTeamGUIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsGUIDDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOperationsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsGUIDLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTeamGUIDDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.timeEdit1);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.addButton);
            this.layoutControl1.Controls.Add(this.workTeamGUIDLookUpEdit);
            this.layoutControl1.Controls.Add(this.nameOperationsTextEdit);
            this.layoutControl1.Controls.Add(this.typeOperationsGUIDLookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(597, 225, 358, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(448, 146);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = "0:00:00";
            this.timeEdit1.Location = new System.Drawing.Point(168, 60);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(268, 20);
            this.timeEdit1.StyleController = this.layoutControl1;
            this.timeEdit1.TabIndex = 15;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(323, 108);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(183, 108);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Сохранить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // workTeamGUIDLookUpEdit
            // 
            this.workTeamGUIDLookUpEdit.Location = new System.Drawing.Point(168, 84);
            this.workTeamGUIDLookUpEdit.Name = "workTeamGUIDLookUpEdit";
            this.workTeamGUIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.workTeamGUIDLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название операции")});
            this.workTeamGUIDLookUpEdit.Properties.DataSource = this.workTeamGUIDDataView;
            this.workTeamGUIDLookUpEdit.Properties.DisplayMember = "Name";
            this.workTeamGUIDLookUpEdit.Properties.ValueMember = "GUID";
            this.workTeamGUIDLookUpEdit.Size = new System.Drawing.Size(268, 20);
            this.workTeamGUIDLookUpEdit.StyleController = this.layoutControl1;
            this.workTeamGUIDLookUpEdit.TabIndex = 6;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule1.ErrorText = "Поле не должно быть пустым!";
            this.dxValidationProvider.SetValidationRule(this.workTeamGUIDLookUpEdit, compareAgainstControlValidationRule1);
            // 
            // typeOperationsGUIDDataView
            // 
            this.typeOperationsGUIDDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            new DevExpress.Xpo.DataViewProperty("GUID", typeof(object)),
            new DevExpress.Xpo.DataViewProperty("Name", typeof(string))});
            // 
            // nameOperationsTextEdit
            // 
            this.nameOperationsTextEdit.Location = new System.Drawing.Point(168, 12);
            this.nameOperationsTextEdit.Name = "nameOperationsTextEdit";
            this.nameOperationsTextEdit.Size = new System.Drawing.Size(268, 20);
            this.nameOperationsTextEdit.StyleController = this.layoutControl1;
            this.nameOperationsTextEdit.TabIndex = 4;
            compareAgainstControlValidationRule2.ErrorText = "Поле не может быть пустым";
            this.dxValidationProvider.SetValidationRule(this.nameOperationsTextEdit, compareAgainstControlValidationRule2);
            // 
            // typeOperationsGUIDLookUpEdit1
            // 
            this.typeOperationsGUIDLookUpEdit1.Location = new System.Drawing.Point(168, 36);
            this.typeOperationsGUIDLookUpEdit1.Name = "typeOperationsGUIDLookUpEdit1";
            this.typeOperationsGUIDLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeOperationsGUIDLookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название типо")});
            this.typeOperationsGUIDLookUpEdit1.Properties.DataSource = this.typeOperationsGUIDDataView;
            this.typeOperationsGUIDLookUpEdit1.Properties.DisplayMember = "Name";
            this.typeOperationsGUIDLookUpEdit1.Properties.ValueMember = "GUID";
            this.typeOperationsGUIDLookUpEdit1.Size = new System.Drawing.Size(268, 20);
            this.typeOperationsGUIDLookUpEdit1.StyleController = this.layoutControl1;
            this.typeOperationsGUIDLookUpEdit1.TabIndex = 6;
            compareAgainstControlValidationRule3.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule3.ErrorText = "Поле не должно быть пустым!";
            this.dxValidationProvider.SetValidationRule(this.typeOperationsGUIDLookUpEdit1, compareAgainstControlValidationRule3);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem9,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(448, 146);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.nameOperationsTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(428, 24);
            this.layoutControlItem1.Text = "Название операции";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(153, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(171, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(140, 30);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(311, 96);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(117, 30);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(171, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.typeOperationsGUIDLookUpEdit1;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem9.CustomizationFormText = "Название типа";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(428, 24);
            this.layoutControlItem9.Text = "Название типа";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(153, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.workTeamGUIDLookUpEdit;
            this.layoutControlItem3.CustomizationFormText = "Рабочая бригада";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(428, 24);
            this.layoutControlItem3.Text = "Рабочая бригада";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(153, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.timeEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(428, 24);
            this.layoutControlItem4.Text = "Время прохождения операции";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(153, 13);
            // 
            // workTeamGUIDDataView
            // 
            this.workTeamGUIDDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            new DevExpress.Xpo.DataViewProperty("GUID", typeof(object)),
            new DevExpress.Xpo.DataViewProperty("Name", typeof(string))});
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 146);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "OperationsForm";
            this.Text = "Операции";
            this.Load += new System.EventHandler(this.OperationsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTeamGUIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsGUIDDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOperationsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOperationsGUIDLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTeamGUIDDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.LookUpEdit workTeamGUIDLookUpEdit;
        private DevExpress.XtraEditors.TextEdit nameOperationsTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.XPDataView workTeamGUIDDataView;
        private DevExpress.XtraEditors.LookUpEdit typeOperationsGUIDLookUpEdit1;
        private DevExpress.Xpo.XPDataView typeOperationsGUIDDataView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}