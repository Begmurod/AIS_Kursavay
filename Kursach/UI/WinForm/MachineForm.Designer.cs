﻿namespace Kursach.UI.WinForm
{
    partial class MachineForm
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
            this.CommissioningDatedateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.baseOperationsGUIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.operationsDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.basetypeGUIDLookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.typeDataView = new DevExpress.Xpo.XPDataView(this.components);
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommissioningDatedateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissioningDatedateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOperationsGUIDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetypeGUIDLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CommissioningDatedateEdit);
            this.layoutControl1.Controls.Add(this.cancelButton);
            this.layoutControl1.Controls.Add(this.addButton);
            this.layoutControl1.Controls.Add(this.baseOperationsGUIDLookUpEdit);
            this.layoutControl1.Controls.Add(this.nameTextEdit);
            this.layoutControl1.Controls.Add(this.basetypeGUIDLookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(597, 225, 358, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(444, 126);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CommissioningDatedateEdit
            // 
            this.CommissioningDatedateEdit.EditValue = null;
            this.CommissioningDatedateEdit.Location = new System.Drawing.Point(154, 72);
            this.CommissioningDatedateEdit.Name = "CommissioningDatedateEdit";
            this.CommissioningDatedateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommissioningDatedateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CommissioningDatedateEdit.Size = new System.Drawing.Size(284, 20);
            this.CommissioningDatedateEdit.StyleController = this.layoutControl1;
            this.CommissioningDatedateEdit.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(302, 94);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 22);
            this.cancelButton.StyleController = this.layoutControl1;
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Отмена";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(154, 94);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(146, 22);
            this.addButton.StyleController = this.layoutControl1;
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Сохранить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // baseOperationsGUIDLookUpEdit
            // 
            this.baseOperationsGUIDLookUpEdit.Location = new System.Drawing.Point(154, 50);
            this.baseOperationsGUIDLookUpEdit.Name = "baseOperationsGUIDLookUpEdit";
            this.baseOperationsGUIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.baseOperationsGUIDLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название операции")});
            this.baseOperationsGUIDLookUpEdit.Properties.DataSource = this.operationsDataView;
            this.baseOperationsGUIDLookUpEdit.Properties.DisplayMember = "Name";
            this.baseOperationsGUIDLookUpEdit.Properties.ValueMember = "GUID";
            this.baseOperationsGUIDLookUpEdit.Size = new System.Drawing.Size(284, 20);
            this.baseOperationsGUIDLookUpEdit.StyleController = this.layoutControl1;
            this.baseOperationsGUIDLookUpEdit.TabIndex = 6;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule1.ErrorText = "Поле не должно быть пустым!";
            this.dxValidationProvider.SetValidationRule(this.baseOperationsGUIDLookUpEdit, compareAgainstControlValidationRule1);
            // 
            // operationsDataView
            // 
            this.operationsDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            new DevExpress.Xpo.DataViewProperty("GUID", typeof(object)),
            new DevExpress.Xpo.DataViewProperty("Name", typeof(string))});
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(154, 6);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(284, 20);
            this.nameTextEdit.StyleController = this.layoutControl1;
            this.nameTextEdit.TabIndex = 4;
            compareAgainstControlValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider.SetValidationRule(this.nameTextEdit, compareAgainstControlValidationRule2);
            // 
            // basetypeGUIDLookUpEdit1
            // 
            this.basetypeGUIDLookUpEdit1.Location = new System.Drawing.Point(154, 28);
            this.basetypeGUIDLookUpEdit1.Name = "basetypeGUIDLookUpEdit1";
            this.basetypeGUIDLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.basetypeGUIDLookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название типо")});
            this.basetypeGUIDLookUpEdit1.Properties.DataSource = this.operationsDataView;
            this.basetypeGUIDLookUpEdit1.Properties.DisplayMember = "Name";
            this.basetypeGUIDLookUpEdit1.Properties.ValueMember = "GUID";
            this.basetypeGUIDLookUpEdit1.Size = new System.Drawing.Size(284, 20);
            this.basetypeGUIDLookUpEdit1.StyleController = this.layoutControl1;
            this.basetypeGUIDLookUpEdit1.TabIndex = 6;
            compareAgainstControlValidationRule3.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals;
            compareAgainstControlValidationRule3.ErrorText = "Поле не должно быть пустым!";
            this.dxValidationProvider.SetValidationRule(this.basetypeGUIDLookUpEdit1, compareAgainstControlValidationRule3);
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
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(444, 126);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.nameTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(434, 22);
            this.layoutControlItem1.Text = "Название агрегата";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(145, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.addButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(148, 88);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(148, 28);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cancelButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(296, 88);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(138, 28);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(148, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.basetypeGUIDLookUpEdit1;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem9.CustomizationFormText = "Тип агрегата";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(434, 22);
            this.layoutControlItem9.Text = "Тип агрегата";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(145, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.baseOperationsGUIDLookUpEdit;
            this.layoutControlItem3.CustomizationFormText = "Операции";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(434, 22);
            this.layoutControlItem3.Text = "Операции";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(145, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.CommissioningDatedateEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 66);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(434, 22);
            this.layoutControlItem2.Text = "Дата ввода в эксплуатацию";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(145, 13);
            // 
            // typeDataView
            // 
            this.typeDataView.Properties.AddRange(new DevExpress.Xpo.DataViewProperty[] {
            new DevExpress.Xpo.DataViewProperty("GUID", typeof(object)),
            new DevExpress.Xpo.DataViewProperty("Name", typeof(string))});
            // 
            // MachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 126);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MachineForm";
            this.Text = "Агрегаты";
            this.Load += new System.EventHandler(this.MachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CommissioningDatedateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommissioningDatedateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseOperationsGUIDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetypeGUIDLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.LookUpEdit baseOperationsGUIDLookUpEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.XPDataView typeDataView;
        private DevExpress.XtraEditors.LookUpEdit basetypeGUIDLookUpEdit1;
        private DevExpress.Xpo.XPDataView operationsDataView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.DateEdit CommissioningDatedateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}