Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace WinWebSolution.Web
	Partial Public Class WinWebSolutionAspNetApplication
		Inherits WebApplication
		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
		Private module3 As WinWebSolution.Module.WinWebSolutionModule
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub WinWebSolutionAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True
		End Sub
		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
			Me.module3 = New WinWebSolution.Module.WinWebSolutionModule()
			Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' module5
			' 
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
			Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
			' 
			' WinWebSolutionAspNetApplication
			' 
			Me.ApplicationName = "WinWebSolution"
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module6)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module5)
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.WinWebSolutionAspNetApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace
