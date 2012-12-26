<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class temporizador_belen
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			Static fTerminateCalled As Boolean
			If Not fTerminateCalled Then
				Form_Terminate_renamed()
				fTerminateCalled = True
			End If
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents CmdStop2 As System.Windows.Forms.Button
    Public WithEvents CmdInicio2 As System.Windows.Forms.Button
    Public WithEvents SF30TXT As System.Windows.Forms.TextBox
    Public WithEvents MF30TXT As System.Windows.Forms.TextBox
    Public WithEvents HF30TXT As System.Windows.Forms.TextBox
    Public WithEvents Transcurrido30 As System.Windows.Forms.TextBox
    Public WithEvents HC30TXT As System.Windows.Forms.TextBox
    Public WithEvents H30ITXT As System.Windows.Forms.TextBox
    Public WithEvents M30ITXT As System.Windows.Forms.TextBox
    Public WithEvents S30ITXT As System.Windows.Forms.TextBox
    Public WithEvents H30FTXT As System.Windows.Forms.TextBox
    Public WithEvents M30FTXT As System.Windows.Forms.TextBox
    Public WithEvents S30FTXT As System.Windows.Forms.TextBox
    Public WithEvents Label78 As System.Windows.Forms.Label
    Public WithEvents Label77 As System.Windows.Forms.Label
    Public WithEvents Label76 As System.Windows.Forms.Label
    Public WithEvents Led30 As System.Windows.Forms.Label
    Public WithEvents Label71 As System.Windows.Forms.Label
    Public WithEvents Label70 As System.Windows.Forms.Label
    Public WithEvents Label69 As System.Windows.Forms.Label
    Public WithEvents Frame16 As System.Windows.Forms.GroupBox
    Public WithEvents H15ITXT As System.Windows.Forms.TextBox
    Public WithEvents M15ITXT As System.Windows.Forms.TextBox
    Public WithEvents S15ITXT As System.Windows.Forms.TextBox
    Public WithEvents H15FTXT As System.Windows.Forms.TextBox
    Public WithEvents M15FTXT As System.Windows.Forms.TextBox
    Public WithEvents S15FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led15 As System.Windows.Forms.Label
    Public WithEvents Label67 As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents Label65 As System.Windows.Forms.Label
    Public WithEvents Frame15 As System.Windows.Forms.GroupBox
    Public WithEvents H14ITXT As System.Windows.Forms.TextBox
    Public WithEvents M14ITXT As System.Windows.Forms.TextBox
    Public WithEvents S14ITXT As System.Windows.Forms.TextBox
    Public WithEvents H14FTXT As System.Windows.Forms.TextBox
    Public WithEvents M14FTXT As System.Windows.Forms.TextBox
    Public WithEvents S14FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led14 As System.Windows.Forms.Label
    Public WithEvents Label63 As System.Windows.Forms.Label
    Public WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Label61 As System.Windows.Forms.Label
    Public WithEvents Frame14 As System.Windows.Forms.GroupBox
    Public WithEvents H13ITXT As System.Windows.Forms.TextBox
    Public WithEvents M13ITXT As System.Windows.Forms.TextBox
    Public WithEvents S13ITXT As System.Windows.Forms.TextBox
    Public WithEvents H13FTXT As System.Windows.Forms.TextBox
    Public WithEvents M13FTXT As System.Windows.Forms.TextBox
    Public WithEvents S13FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led13 As System.Windows.Forms.Label
    Public WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents Label58 As System.Windows.Forms.Label
    Public WithEvents Label57 As System.Windows.Forms.Label
    Public WithEvents Frame13 As System.Windows.Forms.GroupBox
    Public WithEvents H12ITXT As System.Windows.Forms.TextBox
    Public WithEvents M12ITXT As System.Windows.Forms.TextBox
    Public WithEvents S12ITXT As System.Windows.Forms.TextBox
    Public WithEvents H12FTXT As System.Windows.Forms.TextBox
    Public WithEvents M12FTXT As System.Windows.Forms.TextBox
    Public WithEvents S12FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led12 As System.Windows.Forms.Label
    Public WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents Label54 As System.Windows.Forms.Label
    Public WithEvents Label53 As System.Windows.Forms.Label
    Public WithEvents Frame12 As System.Windows.Forms.GroupBox
    Public WithEvents H11ITXT As System.Windows.Forms.TextBox
    Public WithEvents M11ITXT As System.Windows.Forms.TextBox
    Public WithEvents S11ITXT As System.Windows.Forms.TextBox
    Public WithEvents H11FTXT As System.Windows.Forms.TextBox
    Public WithEvents M11FTXT As System.Windows.Forms.TextBox
    Public WithEvents S11FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led11 As System.Windows.Forms.Label
    Public WithEvents Label51 As System.Windows.Forms.Label
    Public WithEvents Label50 As System.Windows.Forms.Label
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents Frame11 As System.Windows.Forms.GroupBox
    Public WithEvents H10ITXT As System.Windows.Forms.TextBox
    Public WithEvents M10ITXT As System.Windows.Forms.TextBox
    Public WithEvents S10ITXT As System.Windows.Forms.TextBox
    Public WithEvents H10FTXT As System.Windows.Forms.TextBox
    Public WithEvents M10FTXT As System.Windows.Forms.TextBox
    Public WithEvents S10FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led10 As System.Windows.Forms.Label
    Public WithEvents Label47 As System.Windows.Forms.Label
    Public WithEvents Label46 As System.Windows.Forms.Label
    Public WithEvents Label45 As System.Windows.Forms.Label
    Public WithEvents Frame10 As System.Windows.Forms.GroupBox
    Public WithEvents H9ITXT As System.Windows.Forms.TextBox
    Public WithEvents M9ITXT As System.Windows.Forms.TextBox
    Public WithEvents S9ITXT As System.Windows.Forms.TextBox
    Public WithEvents H9FTXT As System.Windows.Forms.TextBox
    Public WithEvents M9FTXT As System.Windows.Forms.TextBox
    Public WithEvents S9FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led9 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label42 As System.Windows.Forms.Label
    Public WithEvents Label41 As System.Windows.Forms.Label
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents CmdStop As System.Windows.Forms.Button
    Public WithEvents SGITXT As System.Windows.Forms.TextBox
    Public WithEvents MGITXT As System.Windows.Forms.TextBox
    Public WithEvents HGITXT As System.Windows.Forms.TextBox
    Public WithEvents H8ITXT As System.Windows.Forms.TextBox
    Public WithEvents M8ITXT As System.Windows.Forms.TextBox
    Public WithEvents S8ITXT As System.Windows.Forms.TextBox
    Public WithEvents H8FTXT As System.Windows.Forms.TextBox
    Public WithEvents M8FTXT As System.Windows.Forms.TextBox
    Public WithEvents S8FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led8 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents H7ITXT As System.Windows.Forms.TextBox
    Public WithEvents M7ITXT As System.Windows.Forms.TextBox
    Public WithEvents S7ITXT As System.Windows.Forms.TextBox
    Public WithEvents H7FTXT As System.Windows.Forms.TextBox
    Public WithEvents M7FTXT As System.Windows.Forms.TextBox
    Public WithEvents S7FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led7 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents S6FTXT As System.Windows.Forms.TextBox
    Public WithEvents M6FTXT As System.Windows.Forms.TextBox
    Public WithEvents H6FTXT As System.Windows.Forms.TextBox
    Public WithEvents S6ITXT As System.Windows.Forms.TextBox
    Public WithEvents M6ITXT As System.Windows.Forms.TextBox
    Public WithEvents H6ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Led6 As System.Windows.Forms.Label
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents S5FTXT As System.Windows.Forms.TextBox
    Public WithEvents M5FTXT As System.Windows.Forms.TextBox
    Public WithEvents H5FTXT As System.Windows.Forms.TextBox
    Public WithEvents S5ITXT As System.Windows.Forms.TextBox
    Public WithEvents M5ITXT As System.Windows.Forms.TextBox
    Public WithEvents H5ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Led5 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents S4FTXT As System.Windows.Forms.TextBox
    Public WithEvents M4FTXT As System.Windows.Forms.TextBox
    Public WithEvents H4FTXT As System.Windows.Forms.TextBox
    Public WithEvents S4ITXT As System.Windows.Forms.TextBox
    Public WithEvents M4ITXT As System.Windows.Forms.TextBox
    Public WithEvents H4ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Led4 As System.Windows.Forms.Label
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents S3FTXT As System.Windows.Forms.TextBox
    Public WithEvents M3FTXT As System.Windows.Forms.TextBox
    Public WithEvents H3FTXT As System.Windows.Forms.TextBox
    Public WithEvents S3ITXT As System.Windows.Forms.TextBox
    Public WithEvents M3ITXT As System.Windows.Forms.TextBox
    Public WithEvents H3ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Led3 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents H2ITXT As System.Windows.Forms.TextBox
    Public WithEvents M2ITXT As System.Windows.Forms.TextBox
    Public WithEvents S2ITXT As System.Windows.Forms.TextBox
    Public WithEvents H2FTXT As System.Windows.Forms.TextBox
    Public WithEvents M2FTXT As System.Windows.Forms.TextBox
    Public WithEvents S2FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led2 As System.Windows.Forms.Label
    Public WithEvents _Label9_0 As System.Windows.Forms.Label
    Public WithEvents _Label8_0 As System.Windows.Forms.Label
    Public WithEvents _Label7_0 As System.Windows.Forms.Label
    Public WithEvents _Frame2_0 As System.Windows.Forms.GroupBox
    Public WithEvents HActualTxt As System.Windows.Forms.TextBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents CmdInicio As System.Windows.Forms.Button
    Public WithEvents HCtxt As System.Windows.Forms.TextBox
    Public WithEvents S1FTXT As System.Windows.Forms.TextBox
    Public WithEvents M1FTXT As System.Windows.Forms.TextBox
    Public WithEvents H1FTXT As System.Windows.Forms.TextBox
    Public WithEvents S1ITXT As System.Windows.Forms.TextBox
    Public WithEvents M1ITXT As System.Windows.Forms.TextBox
    Public WithEvents H1ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Led1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label40 As System.Windows.Forms.Label
    Public WithEvents Label39 As System.Windows.Forms.Label
    Public WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents Label74 As System.Windows.Forms.Label
    Public WithEvents Label73 As System.Windows.Forms.Label
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame2 As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
    Public WithEvents Label7 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label8 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label9 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(temporizador_belen))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame16 = New System.Windows.Forms.GroupBox
        Me.CmdStop2 = New System.Windows.Forms.Button
        Me.CmdInicio2 = New System.Windows.Forms.Button
        Me.SF30TXT = New System.Windows.Forms.TextBox
        Me.MF30TXT = New System.Windows.Forms.TextBox
        Me.HF30TXT = New System.Windows.Forms.TextBox
        Me.Transcurrido30 = New System.Windows.Forms.TextBox
        Me.HC30TXT = New System.Windows.Forms.TextBox
        Me.H30ITXT = New System.Windows.Forms.TextBox
        Me.M30ITXT = New System.Windows.Forms.TextBox
        Me.S30ITXT = New System.Windows.Forms.TextBox
        Me.H30FTXT = New System.Windows.Forms.TextBox
        Me.M30FTXT = New System.Windows.Forms.TextBox
        Me.S30FTXT = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.Led30 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Frame15 = New System.Windows.Forms.GroupBox
        Me.H15ITXT = New System.Windows.Forms.TextBox
        Me.M15ITXT = New System.Windows.Forms.TextBox
        Me.S15ITXT = New System.Windows.Forms.TextBox
        Me.H15FTXT = New System.Windows.Forms.TextBox
        Me.M15FTXT = New System.Windows.Forms.TextBox
        Me.S15FTXT = New System.Windows.Forms.TextBox
        Me.Led15 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Frame14 = New System.Windows.Forms.GroupBox
        Me.H14ITXT = New System.Windows.Forms.TextBox
        Me.M14ITXT = New System.Windows.Forms.TextBox
        Me.S14ITXT = New System.Windows.Forms.TextBox
        Me.H14FTXT = New System.Windows.Forms.TextBox
        Me.M14FTXT = New System.Windows.Forms.TextBox
        Me.S14FTXT = New System.Windows.Forms.TextBox
        Me.Led14 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Frame13 = New System.Windows.Forms.GroupBox
        Me.H13ITXT = New System.Windows.Forms.TextBox
        Me.M13ITXT = New System.Windows.Forms.TextBox
        Me.S13ITXT = New System.Windows.Forms.TextBox
        Me.H13FTXT = New System.Windows.Forms.TextBox
        Me.M13FTXT = New System.Windows.Forms.TextBox
        Me.S13FTXT = New System.Windows.Forms.TextBox
        Me.Led13 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Frame12 = New System.Windows.Forms.GroupBox
        Me.H12ITXT = New System.Windows.Forms.TextBox
        Me.M12ITXT = New System.Windows.Forms.TextBox
        Me.S12ITXT = New System.Windows.Forms.TextBox
        Me.H12FTXT = New System.Windows.Forms.TextBox
        Me.M12FTXT = New System.Windows.Forms.TextBox
        Me.S12FTXT = New System.Windows.Forms.TextBox
        Me.Led12 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Frame11 = New System.Windows.Forms.GroupBox
        Me.H11ITXT = New System.Windows.Forms.TextBox
        Me.M11ITXT = New System.Windows.Forms.TextBox
        Me.S11ITXT = New System.Windows.Forms.TextBox
        Me.H11FTXT = New System.Windows.Forms.TextBox
        Me.M11FTXT = New System.Windows.Forms.TextBox
        Me.S11FTXT = New System.Windows.Forms.TextBox
        Me.Led11 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Frame10 = New System.Windows.Forms.GroupBox
        Me.H10ITXT = New System.Windows.Forms.TextBox
        Me.M10ITXT = New System.Windows.Forms.TextBox
        Me.S10ITXT = New System.Windows.Forms.TextBox
        Me.H10FTXT = New System.Windows.Forms.TextBox
        Me.M10FTXT = New System.Windows.Forms.TextBox
        Me.S10FTXT = New System.Windows.Forms.TextBox
        Me.Led10 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Frame9 = New System.Windows.Forms.GroupBox
        Me.H9ITXT = New System.Windows.Forms.TextBox
        Me.M9ITXT = New System.Windows.Forms.TextBox
        Me.S9ITXT = New System.Windows.Forms.TextBox
        Me.H9FTXT = New System.Windows.Forms.TextBox
        Me.M9FTXT = New System.Windows.Forms.TextBox
        Me.S9FTXT = New System.Windows.Forms.TextBox
        Me.Led9 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.CmdStop = New System.Windows.Forms.Button
        Me.SGITXT = New System.Windows.Forms.TextBox
        Me.MGITXT = New System.Windows.Forms.TextBox
        Me.HGITXT = New System.Windows.Forms.TextBox
        Me.Frame8 = New System.Windows.Forms.GroupBox
        Me.H8ITXT = New System.Windows.Forms.TextBox
        Me.M8ITXT = New System.Windows.Forms.TextBox
        Me.S8ITXT = New System.Windows.Forms.TextBox
        Me.H8FTXT = New System.Windows.Forms.TextBox
        Me.M8FTXT = New System.Windows.Forms.TextBox
        Me.S8FTXT = New System.Windows.Forms.TextBox
        Me.Led8 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Frame7 = New System.Windows.Forms.GroupBox
        Me.H7ITXT = New System.Windows.Forms.TextBox
        Me.M7ITXT = New System.Windows.Forms.TextBox
        Me.S7ITXT = New System.Windows.Forms.TextBox
        Me.H7FTXT = New System.Windows.Forms.TextBox
        Me.M7FTXT = New System.Windows.Forms.TextBox
        Me.S7FTXT = New System.Windows.Forms.TextBox
        Me.Led7 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Frame6 = New System.Windows.Forms.GroupBox
        Me.S6FTXT = New System.Windows.Forms.TextBox
        Me.M6FTXT = New System.Windows.Forms.TextBox
        Me.H6FTXT = New System.Windows.Forms.TextBox
        Me.S6ITXT = New System.Windows.Forms.TextBox
        Me.M6ITXT = New System.Windows.Forms.TextBox
        Me.H6ITXT = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Led6 = New System.Windows.Forms.Label
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.S5FTXT = New System.Windows.Forms.TextBox
        Me.M5FTXT = New System.Windows.Forms.TextBox
        Me.H5FTXT = New System.Windows.Forms.TextBox
        Me.S5ITXT = New System.Windows.Forms.TextBox
        Me.M5ITXT = New System.Windows.Forms.TextBox
        Me.H5ITXT = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Led5 = New System.Windows.Forms.Label
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.S4FTXT = New System.Windows.Forms.TextBox
        Me.M4FTXT = New System.Windows.Forms.TextBox
        Me.H4FTXT = New System.Windows.Forms.TextBox
        Me.S4ITXT = New System.Windows.Forms.TextBox
        Me.M4ITXT = New System.Windows.Forms.TextBox
        Me.H4ITXT = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Led4 = New System.Windows.Forms.Label
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.S3FTXT = New System.Windows.Forms.TextBox
        Me.M3FTXT = New System.Windows.Forms.TextBox
        Me.H3FTXT = New System.Windows.Forms.TextBox
        Me.S3ITXT = New System.Windows.Forms.TextBox
        Me.M3ITXT = New System.Windows.Forms.TextBox
        Me.H3ITXT = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Led3 = New System.Windows.Forms.Label
        Me._Frame2_0 = New System.Windows.Forms.GroupBox
        Me.H2ITXT = New System.Windows.Forms.TextBox
        Me.M2ITXT = New System.Windows.Forms.TextBox
        Me.S2ITXT = New System.Windows.Forms.TextBox
        Me.H2FTXT = New System.Windows.Forms.TextBox
        Me.M2FTXT = New System.Windows.Forms.TextBox
        Me.S2FTXT = New System.Windows.Forms.TextBox
        Me.Led2 = New System.Windows.Forms.Label
        Me._Label9_0 = New System.Windows.Forms.Label
        Me._Label8_0 = New System.Windows.Forms.Label
        Me._Label7_0 = New System.Windows.Forms.Label
        Me.HActualTxt = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CmdInicio = New System.Windows.Forms.Button
        Me.HCtxt = New System.Windows.Forms.TextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.S1FTXT = New System.Windows.Forms.TextBox
        Me.M1FTXT = New System.Windows.Forms.TextBox
        Me.H1FTXT = New System.Windows.Forms.TextBox
        Me.S1ITXT = New System.Windows.Forms.TextBox
        Me.M1ITXT = New System.Windows.Forms.TextBox
        Me.H1ITXT = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Led1 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Frame2 = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(Me.components)
        Me.Label7 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label8 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label9 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.H24ITXT = New System.Windows.Forms.TextBox
        Me.M24ITXT = New System.Windows.Forms.TextBox
        Me.S24ITXT = New System.Windows.Forms.TextBox
        Me.H24FTXT = New System.Windows.Forms.TextBox
        Me.M24FTXT = New System.Windows.Forms.TextBox
        Me.S24FTXT = New System.Windows.Forms.TextBox
        Me.Led24 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.H23ITXT = New System.Windows.Forms.TextBox
        Me.M23ITXT = New System.Windows.Forms.TextBox
        Me.S23ITXT = New System.Windows.Forms.TextBox
        Me.H23FTXT = New System.Windows.Forms.TextBox
        Me.M23FTXT = New System.Windows.Forms.TextBox
        Me.S23FTXT = New System.Windows.Forms.TextBox
        Me.Led23 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.S22FTXT = New System.Windows.Forms.TextBox
        Me.M22FTXT = New System.Windows.Forms.TextBox
        Me.H22FTXT = New System.Windows.Forms.TextBox
        Me.S22ITXT = New System.Windows.Forms.TextBox
        Me.M22ITXT = New System.Windows.Forms.TextBox
        Me.H22ITXT = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Led22 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.S21FTXT = New System.Windows.Forms.TextBox
        Me.M21FTXT = New System.Windows.Forms.TextBox
        Me.H21FTXT = New System.Windows.Forms.TextBox
        Me.S21ITXT = New System.Windows.Forms.TextBox
        Me.M21ITXT = New System.Windows.Forms.TextBox
        Me.H21ITXT = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Led21 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.S20FTXT = New System.Windows.Forms.TextBox
        Me.M20FTXT = New System.Windows.Forms.TextBox
        Me.H20FTXT = New System.Windows.Forms.TextBox
        Me.S20ITXT = New System.Windows.Forms.TextBox
        Me.M20ITXT = New System.Windows.Forms.TextBox
        Me.H20ITXT = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Led20 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.S19FTXT = New System.Windows.Forms.TextBox
        Me.M19FTXT = New System.Windows.Forms.TextBox
        Me.H19FTXT = New System.Windows.Forms.TextBox
        Me.S19ITXT = New System.Windows.Forms.TextBox
        Me.M19ITXT = New System.Windows.Forms.TextBox
        Me.H19ITXT = New System.Windows.Forms.TextBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Led19 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.H18ITXT = New System.Windows.Forms.TextBox
        Me.M18ITXT = New System.Windows.Forms.TextBox
        Me.S18ITXT = New System.Windows.Forms.TextBox
        Me.H18FTXT = New System.Windows.Forms.TextBox
        Me.M18FTXT = New System.Windows.Forms.TextBox
        Me.S18FTXT = New System.Windows.Forms.TextBox
        Me.Led18 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.S17FTXT = New System.Windows.Forms.TextBox
        Me.M17FTXT = New System.Windows.Forms.TextBox
        Me.H17FTXT = New System.Windows.Forms.TextBox
        Me.S17ITXT = New System.Windows.Forms.TextBox
        Me.M17ITXT = New System.Windows.Forms.TextBox
        Me.H17ITXT = New System.Windows.Forms.TextBox
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.Label92 = New System.Windows.Forms.Label
        Me.Led17 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.S29FTXT = New System.Windows.Forms.TextBox
        Me.M29FTXT = New System.Windows.Forms.TextBox
        Me.H29FTXT = New System.Windows.Forms.TextBox
        Me.S29ITXT = New System.Windows.Forms.TextBox
        Me.M29ITXT = New System.Windows.Forms.TextBox
        Me.H29ITXT = New System.Windows.Forms.TextBox
        Me.S29 = New System.Windows.Forms.Label
        Me.M29 = New System.Windows.Forms.Label
        Me.H29 = New System.Windows.Forms.Label
        Me.Led29 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.S28FTXT = New System.Windows.Forms.TextBox
        Me.M28FTXT = New System.Windows.Forms.TextBox
        Me.H28FTXT = New System.Windows.Forms.TextBox
        Me.S28ITXT = New System.Windows.Forms.TextBox
        Me.M28ITXT = New System.Windows.Forms.TextBox
        Me.H28ITXT = New System.Windows.Forms.TextBox
        Me.S28 = New System.Windows.Forms.Label
        Me.M28 = New System.Windows.Forms.Label
        Me.H28 = New System.Windows.Forms.Label
        Me.Led28 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.S27FTXT = New System.Windows.Forms.TextBox
        Me.M27FTXT = New System.Windows.Forms.TextBox
        Me.H27FTXT = New System.Windows.Forms.TextBox
        Me.S27ITXT = New System.Windows.Forms.TextBox
        Me.M27ITXT = New System.Windows.Forms.TextBox
        Me.H27ITXT = New System.Windows.Forms.TextBox
        Me.S27 = New System.Windows.Forms.Label
        Me.M27 = New System.Windows.Forms.Label
        Me.H27 = New System.Windows.Forms.Label
        Me.Led27 = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.H26ITXT = New System.Windows.Forms.TextBox
        Me.M26ITXT = New System.Windows.Forms.TextBox
        Me.S26ITXT = New System.Windows.Forms.TextBox
        Me.H26FTXT = New System.Windows.Forms.TextBox
        Me.M26FTXT = New System.Windows.Forms.TextBox
        Me.S26FTXT = New System.Windows.Forms.TextBox
        Me.Led26 = New System.Windows.Forms.Label
        Me.H26 = New System.Windows.Forms.Label
        Me.M26 = New System.Windows.Forms.Label
        Me.S26 = New System.Windows.Forms.Label
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.S25FTXT = New System.Windows.Forms.TextBox
        Me.M25FTXT = New System.Windows.Forms.TextBox
        Me.H25FTXT = New System.Windows.Forms.TextBox
        Me.S25ITXT = New System.Windows.Forms.TextBox
        Me.M25ITXT = New System.Windows.Forms.TextBox
        Me.H25ITXT = New System.Windows.Forms.TextBox
        Me.S25 = New System.Windows.Forms.Label
        Me.M25 = New System.Windows.Forms.Label
        Me.H25 = New System.Windows.Forms.Label
        Me.Led25 = New System.Windows.Forms.Label
        Me.Label108 = New System.Windows.Forms.Label
        Me.Label109 = New System.Windows.Forms.Label
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.H16ITXT = New System.Windows.Forms.TextBox
        Me.M16ITXT = New System.Windows.Forms.TextBox
        Me.S16ITXT = New System.Windows.Forms.TextBox
        Me.H16FTXT = New System.Windows.Forms.TextBox
        Me.M16FTXT = New System.Windows.Forms.TextBox
        Me.S16FTXT = New System.Windows.Forms.TextBox
        Me.Led16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.CmdStop3 = New System.Windows.Forms.Button
        Me.CmdInicio3 = New System.Windows.Forms.Button
        Me.SF31TXT = New System.Windows.Forms.TextBox
        Me.MF31TXT = New System.Windows.Forms.TextBox
        Me.HF31TXT = New System.Windows.Forms.TextBox
        Me.Transcurrido31 = New System.Windows.Forms.TextBox
        Me.HC31TXT = New System.Windows.Forms.TextBox
        Me.H31ITXT = New System.Windows.Forms.TextBox
        Me.M31ITXT = New System.Windows.Forms.TextBox
        Me.S31ITXT = New System.Windows.Forms.TextBox
        Me.H31FTXT = New System.Windows.Forms.TextBox
        Me.M31FTXT = New System.Windows.Forms.TextBox
        Me.S31FTXT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Led31 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label97 = New System.Windows.Forms.Label
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.CmdStop4 = New System.Windows.Forms.Button
        Me.CmdInicio4 = New System.Windows.Forms.Button
        Me.SF32TXT = New System.Windows.Forms.TextBox
        Me.MF32TXT = New System.Windows.Forms.TextBox
        Me.HF32TXT = New System.Windows.Forms.TextBox
        Me.Transcurrido32 = New System.Windows.Forms.TextBox
        Me.HC32TXT = New System.Windows.Forms.TextBox
        Me.H32ITXT = New System.Windows.Forms.TextBox
        Me.M32ITXT = New System.Windows.Forms.TextBox
        Me.S32ITXT = New System.Windows.Forms.TextBox
        Me.H32FTXT = New System.Windows.Forms.TextBox
        Me.M32FTXT = New System.Windows.Forms.TextBox
        Me.S32FTXT = New System.Windows.Forms.TextBox
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label98 = New System.Windows.Forms.Label
        Me.Label99 = New System.Windows.Forms.Label
        Me.Led32 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label103 = New System.Windows.Forms.Label
        Me.MediaPlayer1 = New AxMediaPlayer.AxMediaPlayer
        Me.Frame16.SuspendLayout()
        Me.Frame15.SuspendLayout()
        Me.Frame14.SuspendLayout()
        Me.Frame13.SuspendLayout()
        Me.Frame12.SuspendLayout()
        Me.Frame11.SuspendLayout()
        Me.Frame10.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me._Frame2_0.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Frame16
        '
        Me.Frame16.BackColor = System.Drawing.Color.Transparent
        Me.Frame16.Controls.Add(Me.CmdStop2)
        Me.Frame16.Controls.Add(Me.CmdInicio2)
        Me.Frame16.Controls.Add(Me.SF30TXT)
        Me.Frame16.Controls.Add(Me.MF30TXT)
        Me.Frame16.Controls.Add(Me.HF30TXT)
        Me.Frame16.Controls.Add(Me.Transcurrido30)
        Me.Frame16.Controls.Add(Me.HC30TXT)
        Me.Frame16.Controls.Add(Me.H30ITXT)
        Me.Frame16.Controls.Add(Me.M30ITXT)
        Me.Frame16.Controls.Add(Me.S30ITXT)
        Me.Frame16.Controls.Add(Me.H30FTXT)
        Me.Frame16.Controls.Add(Me.M30FTXT)
        Me.Frame16.Controls.Add(Me.S30FTXT)
        Me.Frame16.Controls.Add(Me.Label78)
        Me.Frame16.Controls.Add(Me.Label77)
        Me.Frame16.Controls.Add(Me.Label76)
        Me.Frame16.Controls.Add(Me.Led30)
        Me.Frame16.Controls.Add(Me.Label71)
        Me.Frame16.Controls.Add(Me.Label70)
        Me.Frame16.Controls.Add(Me.Label69)
        Me.Frame16.ForeColor = System.Drawing.Color.White
        Me.Frame16.Location = New System.Drawing.Point(321, 478)
        Me.Frame16.Name = "Frame16"
        Me.Frame16.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame16.Size = New System.Drawing.Size(202, 217)
        Me.Frame16.TabIndex = 180
        Me.Frame16.TabStop = False
        Me.Frame16.Text = "OUT 30         "
        '
        'CmdStop2
        '
        Me.CmdStop2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdStop2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdStop2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdStop2.Location = New System.Drawing.Point(128, 56)
        Me.CmdStop2.Name = "CmdStop2"
        Me.CmdStop2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdStop2.Size = New System.Drawing.Size(65, 25)
        Me.CmdStop2.TabIndex = 204
        Me.CmdStop2.Text = "Parar"
        Me.CmdStop2.UseVisualStyleBackColor = False
        '
        'CmdInicio2
        '
        Me.CmdInicio2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInicio2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdInicio2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdInicio2.Location = New System.Drawing.Point(128, 24)
        Me.CmdInicio2.Name = "CmdInicio2"
        Me.CmdInicio2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdInicio2.Size = New System.Drawing.Size(65, 25)
        Me.CmdInicio2.TabIndex = 203
        Me.CmdInicio2.Text = "Inicio"
        Me.CmdInicio2.UseVisualStyleBackColor = False
        '
        'SF30TXT
        '
        Me.SF30TXT.AcceptsReturn = True
        Me.SF30TXT.BackColor = System.Drawing.SystemColors.Window
        Me.SF30TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SF30TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SF30TXT.Location = New System.Drawing.Point(160, 104)
        Me.SF30TXT.MaxLength = 0
        Me.SF30TXT.Name = "SF30TXT"
        Me.SF30TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SF30TXT.Size = New System.Drawing.Size(25, 20)
        Me.SF30TXT.TabIndex = 202
        Me.SF30TXT.Text = "0"
        '
        'MF30TXT
        '
        Me.MF30TXT.AcceptsReturn = True
        Me.MF30TXT.BackColor = System.Drawing.SystemColors.Window
        Me.MF30TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MF30TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MF30TXT.Location = New System.Drawing.Point(136, 104)
        Me.MF30TXT.MaxLength = 0
        Me.MF30TXT.Name = "MF30TXT"
        Me.MF30TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MF30TXT.Size = New System.Drawing.Size(25, 20)
        Me.MF30TXT.TabIndex = 201
        Me.MF30TXT.Text = "0"
        '
        'HF30TXT
        '
        Me.HF30TXT.AcceptsReturn = True
        Me.HF30TXT.BackColor = System.Drawing.SystemColors.Window
        Me.HF30TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HF30TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HF30TXT.Location = New System.Drawing.Point(112, 104)
        Me.HF30TXT.MaxLength = 0
        Me.HF30TXT.Name = "HF30TXT"
        Me.HF30TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HF30TXT.Size = New System.Drawing.Size(25, 20)
        Me.HF30TXT.TabIndex = 200
        Me.HF30TXT.Text = "0"
        '
        'Transcurrido30
        '
        Me.Transcurrido30.AcceptsReturn = True
        Me.Transcurrido30.BackColor = System.Drawing.SystemColors.Window
        Me.Transcurrido30.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transcurrido30.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Transcurrido30.Location = New System.Drawing.Point(112, 152)
        Me.Transcurrido30.MaxLength = 0
        Me.Transcurrido30.Name = "Transcurrido30"
        Me.Transcurrido30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Transcurrido30.Size = New System.Drawing.Size(73, 20)
        Me.Transcurrido30.TabIndex = 199
        Me.Transcurrido30.Text = "0"
        '
        'HC30TXT
        '
        Me.HC30TXT.AcceptsReturn = True
        Me.HC30TXT.BackColor = System.Drawing.SystemColors.Window
        Me.HC30TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HC30TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HC30TXT.Location = New System.Drawing.Point(112, 128)
        Me.HC30TXT.MaxLength = 0
        Me.HC30TXT.Name = "HC30TXT"
        Me.HC30TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HC30TXT.Size = New System.Drawing.Size(73, 20)
        Me.HC30TXT.TabIndex = 198
        Me.HC30TXT.Text = "0"
        '
        'H30ITXT
        '
        Me.H30ITXT.AcceptsReturn = True
        Me.H30ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H30ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H30ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H30ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H30ITXT.MaxLength = 0
        Me.H30ITXT.Name = "H30ITXT"
        Me.H30ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H30ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H30ITXT.TabIndex = 186
        Me.H30ITXT.Text = "0"
        '
        'M30ITXT
        '
        Me.M30ITXT.AcceptsReturn = True
        Me.M30ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M30ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M30ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M30ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M30ITXT.MaxLength = 0
        Me.M30ITXT.Name = "M30ITXT"
        Me.M30ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M30ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M30ITXT.TabIndex = 185
        Me.M30ITXT.Text = "0"
        '
        'S30ITXT
        '
        Me.S30ITXT.AcceptsReturn = True
        Me.S30ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S30ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S30ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S30ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S30ITXT.MaxLength = 0
        Me.S30ITXT.Name = "S30ITXT"
        Me.S30ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S30ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S30ITXT.TabIndex = 184
        Me.S30ITXT.Text = "0"
        '
        'H30FTXT
        '
        Me.H30FTXT.AcceptsReturn = True
        Me.H30FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H30FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H30FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H30FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H30FTXT.MaxLength = 0
        Me.H30FTXT.Name = "H30FTXT"
        Me.H30FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H30FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H30FTXT.TabIndex = 183
        Me.H30FTXT.Text = "0"
        '
        'M30FTXT
        '
        Me.M30FTXT.AcceptsReturn = True
        Me.M30FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M30FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M30FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M30FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M30FTXT.MaxLength = 0
        Me.M30FTXT.Name = "M30FTXT"
        Me.M30FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M30FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M30FTXT.TabIndex = 182
        Me.M30FTXT.Text = "0"
        '
        'S30FTXT
        '
        Me.S30FTXT.AcceptsReturn = True
        Me.S30FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S30FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S30FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S30FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S30FTXT.MaxLength = 0
        Me.S30FTXT.Name = "S30FTXT"
        Me.S30FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S30FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S30FTXT.TabIndex = 181
        Me.S30FTXT.Text = "0"
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label78.ForeColor = System.Drawing.Color.White
        Me.Label78.Location = New System.Drawing.Point(8, 152)
        Me.Label78.Name = "Label78"
        Me.Label78.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label78.Size = New System.Drawing.Size(107, 17)
        Me.Label78.TabIndex = 197
        Me.Label78.Text = "Tiempo:"
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label77.ForeColor = System.Drawing.Color.White
        Me.Label77.Location = New System.Drawing.Point(8, 128)
        Me.Label77.Name = "Label77"
        Me.Label77.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label77.Size = New System.Drawing.Size(97, 17)
        Me.Label77.TabIndex = 196
        Me.Label77.Text = "Comienzo:"
        '
        'Label76
        '
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label76.ForeColor = System.Drawing.Color.White
        Me.Label76.Location = New System.Drawing.Point(8, 104)
        Me.Label76.Name = "Label76"
        Me.Label76.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label76.Size = New System.Drawing.Size(73, 17)
        Me.Label76.TabIndex = 195
        Me.Label76.Text = "Repetir cada:"
        '
        'Led30
        '
        Me.Led30.BackColor = System.Drawing.Color.Red
        Me.Led30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led30.Location = New System.Drawing.Point(48, 0)
        Me.Led30.Name = "Led30"
        Me.Led30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led30.Size = New System.Drawing.Size(17, 9)
        Me.Led30.TabIndex = 190
        Me.Led30.Visible = False
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label71.ForeColor = System.Drawing.Color.White
        Me.Label71.Location = New System.Drawing.Point(8, 16)
        Me.Label71.Name = "Label71"
        Me.Label71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label71.Size = New System.Drawing.Size(17, 17)
        Me.Label71.TabIndex = 189
        Me.Label71.Text = "h:"
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label70.ForeColor = System.Drawing.Color.White
        Me.Label70.Location = New System.Drawing.Point(32, 16)
        Me.Label70.Name = "Label70"
        Me.Label70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label70.Size = New System.Drawing.Size(17, 17)
        Me.Label70.TabIndex = 188
        Me.Label70.Text = "m:"
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label69.ForeColor = System.Drawing.Color.White
        Me.Label69.Location = New System.Drawing.Point(56, 16)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label69.Size = New System.Drawing.Size(25, 17)
        Me.Label69.TabIndex = 187
        Me.Label69.Text = "s:"
        '
        'Frame15
        '
        Me.Frame15.BackColor = System.Drawing.Color.Transparent
        Me.Frame15.Controls.Add(Me.H15ITXT)
        Me.Frame15.Controls.Add(Me.M15ITXT)
        Me.Frame15.Controls.Add(Me.S15ITXT)
        Me.Frame15.Controls.Add(Me.H15FTXT)
        Me.Frame15.Controls.Add(Me.M15FTXT)
        Me.Frame15.Controls.Add(Me.S15FTXT)
        Me.Frame15.Controls.Add(Me.Led15)
        Me.Frame15.Controls.Add(Me.Label67)
        Me.Frame15.Controls.Add(Me.Label66)
        Me.Frame15.Controls.Add(Me.Label65)
        Me.Frame15.ForeColor = System.Drawing.Color.White
        Me.Frame15.Location = New System.Drawing.Point(762, 154)
        Me.Frame15.Name = "Frame15"
        Me.Frame15.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame15.Size = New System.Drawing.Size(89, 89)
        Me.Frame15.TabIndex = 169
        Me.Frame15.TabStop = False
        Me.Frame15.Text = "OUT 15          "
        '
        'H15ITXT
        '
        Me.H15ITXT.AcceptsReturn = True
        Me.H15ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H15ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H15ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H15ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H15ITXT.MaxLength = 0
        Me.H15ITXT.Name = "H15ITXT"
        Me.H15ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H15ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H15ITXT.TabIndex = 175
        Me.H15ITXT.Text = "0"
        '
        'M15ITXT
        '
        Me.M15ITXT.AcceptsReturn = True
        Me.M15ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M15ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M15ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M15ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M15ITXT.MaxLength = 0
        Me.M15ITXT.Name = "M15ITXT"
        Me.M15ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M15ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M15ITXT.TabIndex = 174
        Me.M15ITXT.Text = "0"
        '
        'S15ITXT
        '
        Me.S15ITXT.AcceptsReturn = True
        Me.S15ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S15ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S15ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S15ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S15ITXT.MaxLength = 0
        Me.S15ITXT.Name = "S15ITXT"
        Me.S15ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S15ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S15ITXT.TabIndex = 173
        Me.S15ITXT.Text = "0"
        '
        'H15FTXT
        '
        Me.H15FTXT.AcceptsReturn = True
        Me.H15FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H15FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H15FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H15FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H15FTXT.MaxLength = 0
        Me.H15FTXT.Name = "H15FTXT"
        Me.H15FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H15FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H15FTXT.TabIndex = 172
        Me.H15FTXT.Text = "0"
        '
        'M15FTXT
        '
        Me.M15FTXT.AcceptsReturn = True
        Me.M15FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M15FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M15FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M15FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M15FTXT.MaxLength = 0
        Me.M15FTXT.Name = "M15FTXT"
        Me.M15FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M15FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M15FTXT.TabIndex = 171
        Me.M15FTXT.Text = "0"
        '
        'S15FTXT
        '
        Me.S15FTXT.AcceptsReturn = True
        Me.S15FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S15FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S15FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S15FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S15FTXT.MaxLength = 0
        Me.S15FTXT.Name = "S15FTXT"
        Me.S15FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S15FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S15FTXT.TabIndex = 170
        Me.S15FTXT.Text = "0"
        '
        'Led15
        '
        Me.Led15.BackColor = System.Drawing.Color.Red
        Me.Led15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led15.Location = New System.Drawing.Point(48, 0)
        Me.Led15.Name = "Led15"
        Me.Led15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led15.Size = New System.Drawing.Size(17, 9)
        Me.Led15.TabIndex = 179
        Me.Led15.Visible = False
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.ForeColor = System.Drawing.Color.White
        Me.Label67.Location = New System.Drawing.Point(8, 16)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(17, 17)
        Me.Label67.TabIndex = 178
        Me.Label67.Text = "h:"
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.ForeColor = System.Drawing.Color.White
        Me.Label66.Location = New System.Drawing.Point(32, 16)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(19, 17)
        Me.Label66.TabIndex = 177
        Me.Label66.Text = "m:"
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.ForeColor = System.Drawing.Color.White
        Me.Label65.Location = New System.Drawing.Point(56, 16)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(25, 17)
        Me.Label65.TabIndex = 176
        Me.Label65.Text = "s:"
        '
        'Frame14
        '
        Me.Frame14.BackColor = System.Drawing.Color.Transparent
        Me.Frame14.Controls.Add(Me.H14ITXT)
        Me.Frame14.Controls.Add(Me.M14ITXT)
        Me.Frame14.Controls.Add(Me.S14ITXT)
        Me.Frame14.Controls.Add(Me.H14FTXT)
        Me.Frame14.Controls.Add(Me.M14FTXT)
        Me.Frame14.Controls.Add(Me.S14FTXT)
        Me.Frame14.Controls.Add(Me.Led14)
        Me.Frame14.Controls.Add(Me.Label63)
        Me.Frame14.Controls.Add(Me.Label62)
        Me.Frame14.Controls.Add(Me.Label61)
        Me.Frame14.ForeColor = System.Drawing.Color.White
        Me.Frame14.Location = New System.Drawing.Point(649, 154)
        Me.Frame14.Name = "Frame14"
        Me.Frame14.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame14.Size = New System.Drawing.Size(89, 89)
        Me.Frame14.TabIndex = 158
        Me.Frame14.TabStop = False
        Me.Frame14.Text = "OUT 14          "
        '
        'H14ITXT
        '
        Me.H14ITXT.AcceptsReturn = True
        Me.H14ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H14ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H14ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H14ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H14ITXT.MaxLength = 0
        Me.H14ITXT.Name = "H14ITXT"
        Me.H14ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H14ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H14ITXT.TabIndex = 164
        Me.H14ITXT.Text = "0"
        '
        'M14ITXT
        '
        Me.M14ITXT.AcceptsReturn = True
        Me.M14ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M14ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M14ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M14ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M14ITXT.MaxLength = 0
        Me.M14ITXT.Name = "M14ITXT"
        Me.M14ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M14ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M14ITXT.TabIndex = 163
        Me.M14ITXT.Text = "0"
        '
        'S14ITXT
        '
        Me.S14ITXT.AcceptsReturn = True
        Me.S14ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S14ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S14ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S14ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S14ITXT.MaxLength = 0
        Me.S14ITXT.Name = "S14ITXT"
        Me.S14ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S14ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S14ITXT.TabIndex = 162
        Me.S14ITXT.Text = "0"
        '
        'H14FTXT
        '
        Me.H14FTXT.AcceptsReturn = True
        Me.H14FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H14FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H14FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H14FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H14FTXT.MaxLength = 0
        Me.H14FTXT.Name = "H14FTXT"
        Me.H14FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H14FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H14FTXT.TabIndex = 161
        Me.H14FTXT.Text = "0"
        '
        'M14FTXT
        '
        Me.M14FTXT.AcceptsReturn = True
        Me.M14FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M14FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M14FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M14FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M14FTXT.MaxLength = 0
        Me.M14FTXT.Name = "M14FTXT"
        Me.M14FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M14FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M14FTXT.TabIndex = 160
        Me.M14FTXT.Text = "0"
        '
        'S14FTXT
        '
        Me.S14FTXT.AcceptsReturn = True
        Me.S14FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S14FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S14FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S14FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S14FTXT.MaxLength = 0
        Me.S14FTXT.Name = "S14FTXT"
        Me.S14FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S14FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S14FTXT.TabIndex = 159
        Me.S14FTXT.Text = "0"
        '
        'Led14
        '
        Me.Led14.BackColor = System.Drawing.Color.Red
        Me.Led14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led14.Location = New System.Drawing.Point(48, 0)
        Me.Led14.Name = "Led14"
        Me.Led14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led14.Size = New System.Drawing.Size(17, 9)
        Me.Led14.TabIndex = 168
        Me.Led14.Visible = False
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label63.ForeColor = System.Drawing.Color.White
        Me.Label63.Location = New System.Drawing.Point(8, 16)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(17, 17)
        Me.Label63.TabIndex = 167
        Me.Label63.Text = "h:"
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label62.ForeColor = System.Drawing.Color.White
        Me.Label62.Location = New System.Drawing.Point(32, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(19, 17)
        Me.Label62.TabIndex = 166
        Me.Label62.Text = "m:"
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.ForeColor = System.Drawing.Color.White
        Me.Label61.Location = New System.Drawing.Point(56, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(25, 17)
        Me.Label61.TabIndex = 165
        Me.Label61.Text = "s:"
        '
        'Frame13
        '
        Me.Frame13.BackColor = System.Drawing.Color.Transparent
        Me.Frame13.Controls.Add(Me.H13ITXT)
        Me.Frame13.Controls.Add(Me.M13ITXT)
        Me.Frame13.Controls.Add(Me.S13ITXT)
        Me.Frame13.Controls.Add(Me.H13FTXT)
        Me.Frame13.Controls.Add(Me.M13FTXT)
        Me.Frame13.Controls.Add(Me.S13FTXT)
        Me.Frame13.Controls.Add(Me.Led13)
        Me.Frame13.Controls.Add(Me.Label59)
        Me.Frame13.Controls.Add(Me.Label58)
        Me.Frame13.Controls.Add(Me.Label57)
        Me.Frame13.ForeColor = System.Drawing.Color.White
        Me.Frame13.Location = New System.Drawing.Point(536, 154)
        Me.Frame13.Name = "Frame13"
        Me.Frame13.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame13.Size = New System.Drawing.Size(89, 89)
        Me.Frame13.TabIndex = 147
        Me.Frame13.TabStop = False
        Me.Frame13.Text = "OUT 13          "
        '
        'H13ITXT
        '
        Me.H13ITXT.AcceptsReturn = True
        Me.H13ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H13ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H13ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H13ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H13ITXT.MaxLength = 0
        Me.H13ITXT.Name = "H13ITXT"
        Me.H13ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H13ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H13ITXT.TabIndex = 153
        Me.H13ITXT.Text = "0"
        '
        'M13ITXT
        '
        Me.M13ITXT.AcceptsReturn = True
        Me.M13ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M13ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M13ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M13ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M13ITXT.MaxLength = 0
        Me.M13ITXT.Name = "M13ITXT"
        Me.M13ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M13ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M13ITXT.TabIndex = 152
        Me.M13ITXT.Text = "0"
        '
        'S13ITXT
        '
        Me.S13ITXT.AcceptsReturn = True
        Me.S13ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S13ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S13ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S13ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S13ITXT.MaxLength = 0
        Me.S13ITXT.Name = "S13ITXT"
        Me.S13ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S13ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S13ITXT.TabIndex = 151
        Me.S13ITXT.Text = "0"
        '
        'H13FTXT
        '
        Me.H13FTXT.AcceptsReturn = True
        Me.H13FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H13FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H13FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H13FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H13FTXT.MaxLength = 0
        Me.H13FTXT.Name = "H13FTXT"
        Me.H13FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H13FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H13FTXT.TabIndex = 150
        Me.H13FTXT.Text = "0"
        '
        'M13FTXT
        '
        Me.M13FTXT.AcceptsReturn = True
        Me.M13FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M13FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M13FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M13FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M13FTXT.MaxLength = 0
        Me.M13FTXT.Name = "M13FTXT"
        Me.M13FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M13FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M13FTXT.TabIndex = 149
        Me.M13FTXT.Text = "0"
        '
        'S13FTXT
        '
        Me.S13FTXT.AcceptsReturn = True
        Me.S13FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S13FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S13FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S13FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S13FTXT.MaxLength = 0
        Me.S13FTXT.Name = "S13FTXT"
        Me.S13FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S13FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S13FTXT.TabIndex = 148
        Me.S13FTXT.Text = "0"
        '
        'Led13
        '
        Me.Led13.BackColor = System.Drawing.Color.Red
        Me.Led13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led13.Location = New System.Drawing.Point(48, 0)
        Me.Led13.Name = "Led13"
        Me.Led13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led13.Size = New System.Drawing.Size(17, 9)
        Me.Led13.TabIndex = 157
        Me.Led13.Visible = False
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.ForeColor = System.Drawing.Color.White
        Me.Label59.Location = New System.Drawing.Point(8, 16)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(17, 17)
        Me.Label59.TabIndex = 156
        Me.Label59.Text = "h:"
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.ForeColor = System.Drawing.Color.White
        Me.Label58.Location = New System.Drawing.Point(32, 16)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label58.Size = New System.Drawing.Size(19, 17)
        Me.Label58.TabIndex = 155
        Me.Label58.Text = "m:"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(56, 16)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(25, 17)
        Me.Label57.TabIndex = 154
        Me.Label57.Text = "s:"
        '
        'Frame12
        '
        Me.Frame12.BackColor = System.Drawing.Color.Transparent
        Me.Frame12.Controls.Add(Me.H12ITXT)
        Me.Frame12.Controls.Add(Me.M12ITXT)
        Me.Frame12.Controls.Add(Me.S12ITXT)
        Me.Frame12.Controls.Add(Me.H12FTXT)
        Me.Frame12.Controls.Add(Me.M12FTXT)
        Me.Frame12.Controls.Add(Me.S12FTXT)
        Me.Frame12.Controls.Add(Me.Led12)
        Me.Frame12.Controls.Add(Me.Label55)
        Me.Frame12.Controls.Add(Me.Label54)
        Me.Frame12.Controls.Add(Me.Label53)
        Me.Frame12.ForeColor = System.Drawing.Color.White
        Me.Frame12.Location = New System.Drawing.Point(423, 154)
        Me.Frame12.Name = "Frame12"
        Me.Frame12.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame12.Size = New System.Drawing.Size(89, 89)
        Me.Frame12.TabIndex = 136
        Me.Frame12.TabStop = False
        Me.Frame12.Text = "OUT 12          "
        '
        'H12ITXT
        '
        Me.H12ITXT.AcceptsReturn = True
        Me.H12ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H12ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H12ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H12ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H12ITXT.MaxLength = 0
        Me.H12ITXT.Name = "H12ITXT"
        Me.H12ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H12ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H12ITXT.TabIndex = 142
        Me.H12ITXT.Text = "0"
        '
        'M12ITXT
        '
        Me.M12ITXT.AcceptsReturn = True
        Me.M12ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M12ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M12ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M12ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M12ITXT.MaxLength = 0
        Me.M12ITXT.Name = "M12ITXT"
        Me.M12ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M12ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M12ITXT.TabIndex = 141
        Me.M12ITXT.Text = "0"
        '
        'S12ITXT
        '
        Me.S12ITXT.AcceptsReturn = True
        Me.S12ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S12ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S12ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S12ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S12ITXT.MaxLength = 0
        Me.S12ITXT.Name = "S12ITXT"
        Me.S12ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S12ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S12ITXT.TabIndex = 140
        Me.S12ITXT.Text = "0"
        '
        'H12FTXT
        '
        Me.H12FTXT.AcceptsReturn = True
        Me.H12FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H12FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H12FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H12FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H12FTXT.MaxLength = 0
        Me.H12FTXT.Name = "H12FTXT"
        Me.H12FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H12FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H12FTXT.TabIndex = 139
        Me.H12FTXT.Text = "0"
        '
        'M12FTXT
        '
        Me.M12FTXT.AcceptsReturn = True
        Me.M12FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M12FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M12FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M12FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M12FTXT.MaxLength = 0
        Me.M12FTXT.Name = "M12FTXT"
        Me.M12FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M12FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M12FTXT.TabIndex = 138
        Me.M12FTXT.Text = "0"
        '
        'S12FTXT
        '
        Me.S12FTXT.AcceptsReturn = True
        Me.S12FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S12FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S12FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S12FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S12FTXT.MaxLength = 0
        Me.S12FTXT.Name = "S12FTXT"
        Me.S12FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S12FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S12FTXT.TabIndex = 137
        Me.S12FTXT.Text = "0"
        '
        'Led12
        '
        Me.Led12.BackColor = System.Drawing.Color.Red
        Me.Led12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led12.Location = New System.Drawing.Point(48, 0)
        Me.Led12.Name = "Led12"
        Me.Led12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led12.Size = New System.Drawing.Size(17, 9)
        Me.Led12.TabIndex = 146
        Me.Led12.Visible = False
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(8, 16)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(17, 17)
        Me.Label55.TabIndex = 145
        Me.Label55.Text = "h:"
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(32, 16)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(19, 17)
        Me.Label54.TabIndex = 144
        Me.Label54.Text = "m:"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(56, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label53.Size = New System.Drawing.Size(25, 17)
        Me.Label53.TabIndex = 143
        Me.Label53.Text = "s:"
        '
        'Frame11
        '
        Me.Frame11.BackColor = System.Drawing.Color.Transparent
        Me.Frame11.Controls.Add(Me.H11ITXT)
        Me.Frame11.Controls.Add(Me.M11ITXT)
        Me.Frame11.Controls.Add(Me.S11ITXT)
        Me.Frame11.Controls.Add(Me.H11FTXT)
        Me.Frame11.Controls.Add(Me.M11FTXT)
        Me.Frame11.Controls.Add(Me.S11FTXT)
        Me.Frame11.Controls.Add(Me.Led11)
        Me.Frame11.Controls.Add(Me.Label51)
        Me.Frame11.Controls.Add(Me.Label50)
        Me.Frame11.Controls.Add(Me.Label49)
        Me.Frame11.ForeColor = System.Drawing.Color.White
        Me.Frame11.Location = New System.Drawing.Point(309, 154)
        Me.Frame11.Name = "Frame11"
        Me.Frame11.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame11.Size = New System.Drawing.Size(89, 89)
        Me.Frame11.TabIndex = 125
        Me.Frame11.TabStop = False
        Me.Frame11.Text = "OUT 11          "
        '
        'H11ITXT
        '
        Me.H11ITXT.AcceptsReturn = True
        Me.H11ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H11ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H11ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H11ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H11ITXT.MaxLength = 0
        Me.H11ITXT.Name = "H11ITXT"
        Me.H11ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H11ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H11ITXT.TabIndex = 131
        Me.H11ITXT.Text = "0"
        '
        'M11ITXT
        '
        Me.M11ITXT.AcceptsReturn = True
        Me.M11ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M11ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M11ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M11ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M11ITXT.MaxLength = 0
        Me.M11ITXT.Name = "M11ITXT"
        Me.M11ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M11ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M11ITXT.TabIndex = 130
        Me.M11ITXT.Text = "0"
        '
        'S11ITXT
        '
        Me.S11ITXT.AcceptsReturn = True
        Me.S11ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S11ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S11ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S11ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S11ITXT.MaxLength = 0
        Me.S11ITXT.Name = "S11ITXT"
        Me.S11ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S11ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S11ITXT.TabIndex = 129
        Me.S11ITXT.Text = "0"
        '
        'H11FTXT
        '
        Me.H11FTXT.AcceptsReturn = True
        Me.H11FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H11FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H11FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H11FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H11FTXT.MaxLength = 0
        Me.H11FTXT.Name = "H11FTXT"
        Me.H11FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H11FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H11FTXT.TabIndex = 128
        Me.H11FTXT.Text = "0"
        '
        'M11FTXT
        '
        Me.M11FTXT.AcceptsReturn = True
        Me.M11FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M11FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M11FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M11FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M11FTXT.MaxLength = 0
        Me.M11FTXT.Name = "M11FTXT"
        Me.M11FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M11FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M11FTXT.TabIndex = 127
        Me.M11FTXT.Text = "0"
        '
        'S11FTXT
        '
        Me.S11FTXT.AcceptsReturn = True
        Me.S11FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S11FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S11FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S11FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S11FTXT.MaxLength = 0
        Me.S11FTXT.Name = "S11FTXT"
        Me.S11FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S11FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S11FTXT.TabIndex = 126
        Me.S11FTXT.Text = "0"
        '
        'Led11
        '
        Me.Led11.BackColor = System.Drawing.Color.Red
        Me.Led11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led11.Location = New System.Drawing.Point(48, 0)
        Me.Led11.Name = "Led11"
        Me.Led11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led11.Size = New System.Drawing.Size(17, 9)
        Me.Led11.TabIndex = 135
        Me.Led11.Visible = False
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(8, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label51.Size = New System.Drawing.Size(17, 17)
        Me.Label51.TabIndex = 134
        Me.Label51.Text = "h:"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(32, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label50.Size = New System.Drawing.Size(19, 17)
        Me.Label50.TabIndex = 133
        Me.Label50.Text = "m:"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(56, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(25, 17)
        Me.Label49.TabIndex = 132
        Me.Label49.Text = "s:"
        '
        'Frame10
        '
        Me.Frame10.BackColor = System.Drawing.Color.Transparent
        Me.Frame10.Controls.Add(Me.H10ITXT)
        Me.Frame10.Controls.Add(Me.M10ITXT)
        Me.Frame10.Controls.Add(Me.S10ITXT)
        Me.Frame10.Controls.Add(Me.H10FTXT)
        Me.Frame10.Controls.Add(Me.M10FTXT)
        Me.Frame10.Controls.Add(Me.S10FTXT)
        Me.Frame10.Controls.Add(Me.Led10)
        Me.Frame10.Controls.Add(Me.Label47)
        Me.Frame10.Controls.Add(Me.Label46)
        Me.Frame10.Controls.Add(Me.Label45)
        Me.Frame10.ForeColor = System.Drawing.Color.White
        Me.Frame10.Location = New System.Drawing.Point(193, 154)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame10.Size = New System.Drawing.Size(89, 89)
        Me.Frame10.TabIndex = 114
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "OUT 10          "
        '
        'H10ITXT
        '
        Me.H10ITXT.AcceptsReturn = True
        Me.H10ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H10ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H10ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H10ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H10ITXT.MaxLength = 0
        Me.H10ITXT.Name = "H10ITXT"
        Me.H10ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H10ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H10ITXT.TabIndex = 120
        Me.H10ITXT.Text = "0"
        '
        'M10ITXT
        '
        Me.M10ITXT.AcceptsReturn = True
        Me.M10ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M10ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M10ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M10ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M10ITXT.MaxLength = 0
        Me.M10ITXT.Name = "M10ITXT"
        Me.M10ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M10ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M10ITXT.TabIndex = 119
        Me.M10ITXT.Text = "0"
        '
        'S10ITXT
        '
        Me.S10ITXT.AcceptsReturn = True
        Me.S10ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S10ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S10ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S10ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S10ITXT.MaxLength = 0
        Me.S10ITXT.Name = "S10ITXT"
        Me.S10ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S10ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S10ITXT.TabIndex = 118
        Me.S10ITXT.Text = "0"
        '
        'H10FTXT
        '
        Me.H10FTXT.AcceptsReturn = True
        Me.H10FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H10FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H10FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H10FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H10FTXT.MaxLength = 0
        Me.H10FTXT.Name = "H10FTXT"
        Me.H10FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H10FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H10FTXT.TabIndex = 117
        Me.H10FTXT.Text = "0"
        '
        'M10FTXT
        '
        Me.M10FTXT.AcceptsReturn = True
        Me.M10FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M10FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M10FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M10FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M10FTXT.MaxLength = 0
        Me.M10FTXT.Name = "M10FTXT"
        Me.M10FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M10FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M10FTXT.TabIndex = 116
        Me.M10FTXT.Text = "0"
        '
        'S10FTXT
        '
        Me.S10FTXT.AcceptsReturn = True
        Me.S10FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S10FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S10FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S10FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S10FTXT.MaxLength = 0
        Me.S10FTXT.Name = "S10FTXT"
        Me.S10FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S10FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S10FTXT.TabIndex = 115
        Me.S10FTXT.Text = "0"
        '
        'Led10
        '
        Me.Led10.BackColor = System.Drawing.Color.Red
        Me.Led10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led10.Location = New System.Drawing.Point(48, 0)
        Me.Led10.Name = "Led10"
        Me.Led10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led10.Size = New System.Drawing.Size(17, 9)
        Me.Led10.TabIndex = 124
        Me.Led10.Visible = False
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(8, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(17, 17)
        Me.Label47.TabIndex = 123
        Me.Label47.Text = "h:"
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(32, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label46.Size = New System.Drawing.Size(19, 17)
        Me.Label46.TabIndex = 122
        Me.Label46.Text = "m:"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(56, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(25, 17)
        Me.Label45.TabIndex = 121
        Me.Label45.Text = "s:"
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.Transparent
        Me.Frame9.Controls.Add(Me.H9ITXT)
        Me.Frame9.Controls.Add(Me.M9ITXT)
        Me.Frame9.Controls.Add(Me.S9ITXT)
        Me.Frame9.Controls.Add(Me.H9FTXT)
        Me.Frame9.Controls.Add(Me.M9FTXT)
        Me.Frame9.Controls.Add(Me.S9FTXT)
        Me.Frame9.Controls.Add(Me.Led9)
        Me.Frame9.Controls.Add(Me.Label43)
        Me.Frame9.Controls.Add(Me.Label42)
        Me.Frame9.Controls.Add(Me.Label41)
        Me.Frame9.ForeColor = System.Drawing.Color.White
        Me.Frame9.Location = New System.Drawing.Point(75, 154)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(89, 89)
        Me.Frame9.TabIndex = 103
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "OUT 9          "
        '
        'H9ITXT
        '
        Me.H9ITXT.AcceptsReturn = True
        Me.H9ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H9ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H9ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H9ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H9ITXT.MaxLength = 0
        Me.H9ITXT.Name = "H9ITXT"
        Me.H9ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H9ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H9ITXT.TabIndex = 109
        Me.H9ITXT.Text = "0"
        '
        'M9ITXT
        '
        Me.M9ITXT.AcceptsReturn = True
        Me.M9ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M9ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M9ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M9ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M9ITXT.MaxLength = 0
        Me.M9ITXT.Name = "M9ITXT"
        Me.M9ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M9ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M9ITXT.TabIndex = 108
        Me.M9ITXT.Text = "0"
        '
        'S9ITXT
        '
        Me.S9ITXT.AcceptsReturn = True
        Me.S9ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S9ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S9ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S9ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S9ITXT.MaxLength = 0
        Me.S9ITXT.Name = "S9ITXT"
        Me.S9ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S9ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S9ITXT.TabIndex = 107
        Me.S9ITXT.Text = "0"
        '
        'H9FTXT
        '
        Me.H9FTXT.AcceptsReturn = True
        Me.H9FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H9FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H9FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H9FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H9FTXT.MaxLength = 0
        Me.H9FTXT.Name = "H9FTXT"
        Me.H9FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H9FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H9FTXT.TabIndex = 106
        Me.H9FTXT.Text = "0"
        '
        'M9FTXT
        '
        Me.M9FTXT.AcceptsReturn = True
        Me.M9FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M9FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M9FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M9FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M9FTXT.MaxLength = 0
        Me.M9FTXT.Name = "M9FTXT"
        Me.M9FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M9FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M9FTXT.TabIndex = 105
        Me.M9FTXT.Text = "0"
        '
        'S9FTXT
        '
        Me.S9FTXT.AcceptsReturn = True
        Me.S9FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S9FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S9FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S9FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S9FTXT.MaxLength = 0
        Me.S9FTXT.Name = "S9FTXT"
        Me.S9FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S9FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S9FTXT.TabIndex = 104
        Me.S9FTXT.Text = "0"
        '
        'Led9
        '
        Me.Led9.BackColor = System.Drawing.Color.Red
        Me.Led9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led9.Location = New System.Drawing.Point(48, 0)
        Me.Led9.Name = "Led9"
        Me.Led9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led9.Size = New System.Drawing.Size(17, 9)
        Me.Led9.TabIndex = 113
        Me.Led9.Visible = False
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(8, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(17, 17)
        Me.Label43.TabIndex = 112
        Me.Label43.Text = "h:"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(32, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(19, 17)
        Me.Label42.TabIndex = 111
        Me.Label42.Text = "m:"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(56, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(25, 17)
        Me.Label41.TabIndex = 110
        Me.Label41.Text = "s:"
        '
        'CmdStop
        '
        Me.CmdStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdStop.Location = New System.Drawing.Point(230, 604)
        Me.CmdStop.Name = "CmdStop"
        Me.CmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdStop.Size = New System.Drawing.Size(57, 25)
        Me.CmdStop.TabIndex = 102
        Me.CmdStop.Text = "Parar"
        Me.CmdStop.UseVisualStyleBackColor = False
        '
        'SGITXT
        '
        Me.SGITXT.AcceptsReturn = True
        Me.SGITXT.BackColor = System.Drawing.SystemColors.Window
        Me.SGITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SGITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SGITXT.Location = New System.Drawing.Point(186, 572)
        Me.SGITXT.MaxLength = 0
        Me.SGITXT.Name = "SGITXT"
        Me.SGITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SGITXT.Size = New System.Drawing.Size(25, 20)
        Me.SGITXT.TabIndex = 95
        Me.SGITXT.Text = "0"
        '
        'MGITXT
        '
        Me.MGITXT.AcceptsReturn = True
        Me.MGITXT.BackColor = System.Drawing.SystemColors.Window
        Me.MGITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MGITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MGITXT.Location = New System.Drawing.Point(162, 572)
        Me.MGITXT.MaxLength = 0
        Me.MGITXT.Name = "MGITXT"
        Me.MGITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MGITXT.Size = New System.Drawing.Size(25, 20)
        Me.MGITXT.TabIndex = 94
        Me.MGITXT.Text = "0"
        '
        'HGITXT
        '
        Me.HGITXT.AcceptsReturn = True
        Me.HGITXT.BackColor = System.Drawing.SystemColors.Window
        Me.HGITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HGITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HGITXT.Location = New System.Drawing.Point(138, 572)
        Me.HGITXT.MaxLength = 0
        Me.HGITXT.Name = "HGITXT"
        Me.HGITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HGITXT.Size = New System.Drawing.Size(25, 20)
        Me.HGITXT.TabIndex = 93
        Me.HGITXT.Text = "0"
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.Color.Transparent
        Me.Frame8.Controls.Add(Me.H8ITXT)
        Me.Frame8.Controls.Add(Me.M8ITXT)
        Me.Frame8.Controls.Add(Me.S8ITXT)
        Me.Frame8.Controls.Add(Me.H8FTXT)
        Me.Frame8.Controls.Add(Me.M8FTXT)
        Me.Frame8.Controls.Add(Me.S8FTXT)
        Me.Frame8.Controls.Add(Me.Led8)
        Me.Frame8.Controls.Add(Me.Label33)
        Me.Frame8.Controls.Add(Me.Label32)
        Me.Frame8.Controls.Add(Me.Label31)
        Me.Frame8.ForeColor = System.Drawing.Color.White
        Me.Frame8.Location = New System.Drawing.Point(872, 59)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(89, 89)
        Me.Frame8.TabIndex = 82
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "OUT 8          "
        '
        'H8ITXT
        '
        Me.H8ITXT.AcceptsReturn = True
        Me.H8ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H8ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H8ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H8ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H8ITXT.MaxLength = 0
        Me.H8ITXT.Name = "H8ITXT"
        Me.H8ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H8ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H8ITXT.TabIndex = 88
        Me.H8ITXT.Text = "0"
        '
        'M8ITXT
        '
        Me.M8ITXT.AcceptsReturn = True
        Me.M8ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M8ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M8ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M8ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M8ITXT.MaxLength = 0
        Me.M8ITXT.Name = "M8ITXT"
        Me.M8ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M8ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M8ITXT.TabIndex = 87
        Me.M8ITXT.Text = "0"
        '
        'S8ITXT
        '
        Me.S8ITXT.AcceptsReturn = True
        Me.S8ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S8ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S8ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S8ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S8ITXT.MaxLength = 0
        Me.S8ITXT.Name = "S8ITXT"
        Me.S8ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S8ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S8ITXT.TabIndex = 86
        Me.S8ITXT.Text = "0"
        '
        'H8FTXT
        '
        Me.H8FTXT.AcceptsReturn = True
        Me.H8FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H8FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H8FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H8FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H8FTXT.MaxLength = 0
        Me.H8FTXT.Name = "H8FTXT"
        Me.H8FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H8FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H8FTXT.TabIndex = 85
        Me.H8FTXT.Text = "0"
        '
        'M8FTXT
        '
        Me.M8FTXT.AcceptsReturn = True
        Me.M8FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M8FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M8FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M8FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M8FTXT.MaxLength = 0
        Me.M8FTXT.Name = "M8FTXT"
        Me.M8FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M8FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M8FTXT.TabIndex = 84
        Me.M8FTXT.Text = "0"
        '
        'S8FTXT
        '
        Me.S8FTXT.AcceptsReturn = True
        Me.S8FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S8FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S8FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S8FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S8FTXT.MaxLength = 0
        Me.S8FTXT.Name = "S8FTXT"
        Me.S8FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S8FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S8FTXT.TabIndex = 83
        Me.S8FTXT.Text = "0"
        '
        'Led8
        '
        Me.Led8.BackColor = System.Drawing.Color.Red
        Me.Led8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led8.Location = New System.Drawing.Point(48, 0)
        Me.Led8.Name = "Led8"
        Me.Led8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led8.Size = New System.Drawing.Size(17, 9)
        Me.Led8.TabIndex = 92
        Me.Led8.Visible = False
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(8, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(17, 17)
        Me.Label33.TabIndex = 91
        Me.Label33.Text = "h:"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(32, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(19, 17)
        Me.Label32.TabIndex = 90
        Me.Label32.Text = "m:"
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(56, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(17, 17)
        Me.Label31.TabIndex = 89
        Me.Label31.Text = "s:"
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.Transparent
        Me.Frame7.Controls.Add(Me.H7ITXT)
        Me.Frame7.Controls.Add(Me.M7ITXT)
        Me.Frame7.Controls.Add(Me.S7ITXT)
        Me.Frame7.Controls.Add(Me.H7FTXT)
        Me.Frame7.Controls.Add(Me.M7FTXT)
        Me.Frame7.Controls.Add(Me.S7FTXT)
        Me.Frame7.Controls.Add(Me.Led7)
        Me.Frame7.Controls.Add(Me.Label29)
        Me.Frame7.Controls.Add(Me.Label28)
        Me.Frame7.Controls.Add(Me.Label27)
        Me.Frame7.ForeColor = System.Drawing.Color.White
        Me.Frame7.Location = New System.Drawing.Point(761, 59)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame7.Size = New System.Drawing.Size(89, 89)
        Me.Frame7.TabIndex = 71
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "OUT 7          "
        '
        'H7ITXT
        '
        Me.H7ITXT.AcceptsReturn = True
        Me.H7ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H7ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H7ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H7ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H7ITXT.MaxLength = 0
        Me.H7ITXT.Name = "H7ITXT"
        Me.H7ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H7ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H7ITXT.TabIndex = 77
        Me.H7ITXT.Text = "0"
        '
        'M7ITXT
        '
        Me.M7ITXT.AcceptsReturn = True
        Me.M7ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M7ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M7ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M7ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M7ITXT.MaxLength = 0
        Me.M7ITXT.Name = "M7ITXT"
        Me.M7ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M7ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M7ITXT.TabIndex = 76
        Me.M7ITXT.Text = "0"
        '
        'S7ITXT
        '
        Me.S7ITXT.AcceptsReturn = True
        Me.S7ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S7ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S7ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S7ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S7ITXT.MaxLength = 0
        Me.S7ITXT.Name = "S7ITXT"
        Me.S7ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S7ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S7ITXT.TabIndex = 75
        Me.S7ITXT.Text = "0"
        '
        'H7FTXT
        '
        Me.H7FTXT.AcceptsReturn = True
        Me.H7FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H7FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H7FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H7FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H7FTXT.MaxLength = 0
        Me.H7FTXT.Name = "H7FTXT"
        Me.H7FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H7FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H7FTXT.TabIndex = 74
        Me.H7FTXT.Text = "0"
        '
        'M7FTXT
        '
        Me.M7FTXT.AcceptsReturn = True
        Me.M7FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M7FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M7FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M7FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M7FTXT.MaxLength = 0
        Me.M7FTXT.Name = "M7FTXT"
        Me.M7FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M7FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M7FTXT.TabIndex = 73
        Me.M7FTXT.Text = "0"
        '
        'S7FTXT
        '
        Me.S7FTXT.AcceptsReturn = True
        Me.S7FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S7FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S7FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S7FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S7FTXT.MaxLength = 0
        Me.S7FTXT.Name = "S7FTXT"
        Me.S7FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S7FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S7FTXT.TabIndex = 72
        Me.S7FTXT.Text = "0"
        '
        'Led7
        '
        Me.Led7.BackColor = System.Drawing.Color.Red
        Me.Led7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led7.Location = New System.Drawing.Point(48, 0)
        Me.Led7.Name = "Led7"
        Me.Led7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led7.Size = New System.Drawing.Size(17, 9)
        Me.Led7.TabIndex = 81
        Me.Led7.Visible = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(8, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(17, 17)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "h:"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(32, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(19, 17)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "m:"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(56, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(17, 17)
        Me.Label27.TabIndex = 78
        Me.Label27.Text = "s:"
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.Transparent
        Me.Frame6.Controls.Add(Me.S6FTXT)
        Me.Frame6.Controls.Add(Me.M6FTXT)
        Me.Frame6.Controls.Add(Me.H6FTXT)
        Me.Frame6.Controls.Add(Me.S6ITXT)
        Me.Frame6.Controls.Add(Me.M6ITXT)
        Me.Frame6.Controls.Add(Me.H6ITXT)
        Me.Frame6.Controls.Add(Me.Label26)
        Me.Frame6.Controls.Add(Me.Label25)
        Me.Frame6.Controls.Add(Me.Label24)
        Me.Frame6.Controls.Add(Me.Led6)
        Me.Frame6.ForeColor = System.Drawing.Color.White
        Me.Frame6.Location = New System.Drawing.Point(648, 59)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(89, 89)
        Me.Frame6.TabIndex = 60
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "OUT 6          "
        '
        'S6FTXT
        '
        Me.S6FTXT.AcceptsReturn = True
        Me.S6FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S6FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S6FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S6FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S6FTXT.MaxLength = 0
        Me.S6FTXT.Name = "S6FTXT"
        Me.S6FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S6FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S6FTXT.TabIndex = 66
        Me.S6FTXT.Text = "0"
        '
        'M6FTXT
        '
        Me.M6FTXT.AcceptsReturn = True
        Me.M6FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M6FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M6FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M6FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M6FTXT.MaxLength = 0
        Me.M6FTXT.Name = "M6FTXT"
        Me.M6FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M6FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M6FTXT.TabIndex = 65
        Me.M6FTXT.Text = "0"
        '
        'H6FTXT
        '
        Me.H6FTXT.AcceptsReturn = True
        Me.H6FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H6FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H6FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H6FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H6FTXT.MaxLength = 0
        Me.H6FTXT.Name = "H6FTXT"
        Me.H6FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H6FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H6FTXT.TabIndex = 64
        Me.H6FTXT.Text = "0"
        '
        'S6ITXT
        '
        Me.S6ITXT.AcceptsReturn = True
        Me.S6ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S6ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S6ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S6ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S6ITXT.MaxLength = 0
        Me.S6ITXT.Name = "S6ITXT"
        Me.S6ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S6ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S6ITXT.TabIndex = 63
        Me.S6ITXT.Text = "0"
        '
        'M6ITXT
        '
        Me.M6ITXT.AcceptsReturn = True
        Me.M6ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M6ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M6ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M6ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M6ITXT.MaxLength = 0
        Me.M6ITXT.Name = "M6ITXT"
        Me.M6ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M6ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M6ITXT.TabIndex = 62
        Me.M6ITXT.Text = "0"
        '
        'H6ITXT
        '
        Me.H6ITXT.AcceptsReturn = True
        Me.H6ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H6ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H6ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H6ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H6ITXT.MaxLength = 0
        Me.H6ITXT.Name = "H6ITXT"
        Me.H6ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H6ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H6ITXT.TabIndex = 61
        Me.H6ITXT.Text = "0"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(56, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(17, 17)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "s:"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(32, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(19, 17)
        Me.Label25.TabIndex = 69
        Me.Label25.Text = "m:"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(8, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(17, 17)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "h:"
        '
        'Led6
        '
        Me.Led6.BackColor = System.Drawing.Color.Red
        Me.Led6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led6.Location = New System.Drawing.Point(48, 0)
        Me.Led6.Name = "Led6"
        Me.Led6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led6.Size = New System.Drawing.Size(17, 9)
        Me.Led6.TabIndex = 67
        Me.Led6.Visible = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.Transparent
        Me.Frame5.Controls.Add(Me.S5FTXT)
        Me.Frame5.Controls.Add(Me.M5FTXT)
        Me.Frame5.Controls.Add(Me.H5FTXT)
        Me.Frame5.Controls.Add(Me.S5ITXT)
        Me.Frame5.Controls.Add(Me.M5ITXT)
        Me.Frame5.Controls.Add(Me.H5ITXT)
        Me.Frame5.Controls.Add(Me.Label22)
        Me.Frame5.Controls.Add(Me.Label21)
        Me.Frame5.Controls.Add(Me.Label20)
        Me.Frame5.Controls.Add(Me.Led5)
        Me.Frame5.ForeColor = System.Drawing.Color.White
        Me.Frame5.Location = New System.Drawing.Point(535, 59)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(89, 89)
        Me.Frame5.TabIndex = 49
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "OUT 5          "
        '
        'S5FTXT
        '
        Me.S5FTXT.AcceptsReturn = True
        Me.S5FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S5FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S5FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S5FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S5FTXT.MaxLength = 0
        Me.S5FTXT.Name = "S5FTXT"
        Me.S5FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S5FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S5FTXT.TabIndex = 55
        Me.S5FTXT.Text = "0"
        '
        'M5FTXT
        '
        Me.M5FTXT.AcceptsReturn = True
        Me.M5FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M5FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M5FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M5FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M5FTXT.MaxLength = 0
        Me.M5FTXT.Name = "M5FTXT"
        Me.M5FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M5FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M5FTXT.TabIndex = 54
        Me.M5FTXT.Text = "0"
        '
        'H5FTXT
        '
        Me.H5FTXT.AcceptsReturn = True
        Me.H5FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H5FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H5FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H5FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H5FTXT.MaxLength = 0
        Me.H5FTXT.Name = "H5FTXT"
        Me.H5FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H5FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H5FTXT.TabIndex = 53
        Me.H5FTXT.Text = "0"
        '
        'S5ITXT
        '
        Me.S5ITXT.AcceptsReturn = True
        Me.S5ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S5ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S5ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S5ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S5ITXT.MaxLength = 0
        Me.S5ITXT.Name = "S5ITXT"
        Me.S5ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S5ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S5ITXT.TabIndex = 52
        Me.S5ITXT.Text = "0"
        '
        'M5ITXT
        '
        Me.M5ITXT.AcceptsReturn = True
        Me.M5ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M5ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M5ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M5ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M5ITXT.MaxLength = 0
        Me.M5ITXT.Name = "M5ITXT"
        Me.M5ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M5ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M5ITXT.TabIndex = 51
        Me.M5ITXT.Text = "0"
        '
        'H5ITXT
        '
        Me.H5ITXT.AcceptsReturn = True
        Me.H5ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H5ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H5ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H5ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H5ITXT.MaxLength = 0
        Me.H5ITXT.Name = "H5ITXT"
        Me.H5ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H5ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H5ITXT.TabIndex = 50
        Me.H5ITXT.Text = "0"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(56, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(17, 17)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "s:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(32, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(19, 17)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "m:"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(8, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(17, 17)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "h:"
        '
        'Led5
        '
        Me.Led5.BackColor = System.Drawing.Color.Red
        Me.Led5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led5.Location = New System.Drawing.Point(48, 0)
        Me.Led5.Name = "Led5"
        Me.Led5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led5.Size = New System.Drawing.Size(17, 9)
        Me.Led5.TabIndex = 56
        Me.Led5.Visible = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.Transparent
        Me.Frame4.Controls.Add(Me.S4FTXT)
        Me.Frame4.Controls.Add(Me.M4FTXT)
        Me.Frame4.Controls.Add(Me.H4FTXT)
        Me.Frame4.Controls.Add(Me.S4ITXT)
        Me.Frame4.Controls.Add(Me.M4ITXT)
        Me.Frame4.Controls.Add(Me.H4ITXT)
        Me.Frame4.Controls.Add(Me.Label18)
        Me.Frame4.Controls.Add(Me.Label17)
        Me.Frame4.Controls.Add(Me.Label16)
        Me.Frame4.Controls.Add(Me.Led4)
        Me.Frame4.ForeColor = System.Drawing.Color.White
        Me.Frame4.Location = New System.Drawing.Point(422, 59)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(89, 89)
        Me.Frame4.TabIndex = 38
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "OUT 4          "
        '
        'S4FTXT
        '
        Me.S4FTXT.AcceptsReturn = True
        Me.S4FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S4FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S4FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S4FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S4FTXT.MaxLength = 0
        Me.S4FTXT.Name = "S4FTXT"
        Me.S4FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S4FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S4FTXT.TabIndex = 44
        Me.S4FTXT.Text = "0"
        '
        'M4FTXT
        '
        Me.M4FTXT.AcceptsReturn = True
        Me.M4FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M4FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M4FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M4FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M4FTXT.MaxLength = 0
        Me.M4FTXT.Name = "M4FTXT"
        Me.M4FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M4FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M4FTXT.TabIndex = 43
        Me.M4FTXT.Text = "0"
        '
        'H4FTXT
        '
        Me.H4FTXT.AcceptsReturn = True
        Me.H4FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H4FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H4FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H4FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H4FTXT.MaxLength = 0
        Me.H4FTXT.Name = "H4FTXT"
        Me.H4FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H4FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H4FTXT.TabIndex = 42
        Me.H4FTXT.Text = "0"
        '
        'S4ITXT
        '
        Me.S4ITXT.AcceptsReturn = True
        Me.S4ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S4ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S4ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S4ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S4ITXT.MaxLength = 0
        Me.S4ITXT.Name = "S4ITXT"
        Me.S4ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S4ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S4ITXT.TabIndex = 41
        Me.S4ITXT.Text = "0"
        '
        'M4ITXT
        '
        Me.M4ITXT.AcceptsReturn = True
        Me.M4ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M4ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M4ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M4ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M4ITXT.MaxLength = 0
        Me.M4ITXT.Name = "M4ITXT"
        Me.M4ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M4ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M4ITXT.TabIndex = 40
        Me.M4ITXT.Text = "0"
        '
        'H4ITXT
        '
        Me.H4ITXT.AcceptsReturn = True
        Me.H4ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H4ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H4ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H4ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H4ITXT.MaxLength = 0
        Me.H4ITXT.Name = "H4ITXT"
        Me.H4ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H4ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H4ITXT.TabIndex = 39
        Me.H4ITXT.Text = "0"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(56, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(17, 17)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "s:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(32, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(19, 17)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "m:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(8, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(17, 17)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "h:"
        '
        'Led4
        '
        Me.Led4.BackColor = System.Drawing.Color.Red
        Me.Led4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led4.Location = New System.Drawing.Point(48, 0)
        Me.Led4.Name = "Led4"
        Me.Led4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led4.Size = New System.Drawing.Size(17, 9)
        Me.Led4.TabIndex = 45
        Me.Led4.Visible = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.Transparent
        Me.Frame3.Controls.Add(Me.S3FTXT)
        Me.Frame3.Controls.Add(Me.M3FTXT)
        Me.Frame3.Controls.Add(Me.H3FTXT)
        Me.Frame3.Controls.Add(Me.S3ITXT)
        Me.Frame3.Controls.Add(Me.M3ITXT)
        Me.Frame3.Controls.Add(Me.H3ITXT)
        Me.Frame3.Controls.Add(Me.Label14)
        Me.Frame3.Controls.Add(Me.Label13)
        Me.Frame3.Controls.Add(Me.Label11)
        Me.Frame3.Controls.Add(Me.Led3)
        Me.Frame3.ForeColor = System.Drawing.Color.White
        Me.Frame3.Location = New System.Drawing.Point(308, 59)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(89, 89)
        Me.Frame3.TabIndex = 27
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "OUT 3          "
        '
        'S3FTXT
        '
        Me.S3FTXT.AcceptsReturn = True
        Me.S3FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S3FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S3FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S3FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S3FTXT.MaxLength = 0
        Me.S3FTXT.Name = "S3FTXT"
        Me.S3FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S3FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S3FTXT.TabIndex = 33
        Me.S3FTXT.Text = "0"
        '
        'M3FTXT
        '
        Me.M3FTXT.AcceptsReturn = True
        Me.M3FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M3FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M3FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M3FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M3FTXT.MaxLength = 0
        Me.M3FTXT.Name = "M3FTXT"
        Me.M3FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M3FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M3FTXT.TabIndex = 32
        Me.M3FTXT.Text = "0"
        '
        'H3FTXT
        '
        Me.H3FTXT.AcceptsReturn = True
        Me.H3FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H3FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H3FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H3FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H3FTXT.MaxLength = 0
        Me.H3FTXT.Name = "H3FTXT"
        Me.H3FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H3FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H3FTXT.TabIndex = 31
        Me.H3FTXT.Text = "0"
        '
        'S3ITXT
        '
        Me.S3ITXT.AcceptsReturn = True
        Me.S3ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S3ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S3ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S3ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S3ITXT.MaxLength = 0
        Me.S3ITXT.Name = "S3ITXT"
        Me.S3ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S3ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S3ITXT.TabIndex = 30
        Me.S3ITXT.Text = "0"
        '
        'M3ITXT
        '
        Me.M3ITXT.AcceptsReturn = True
        Me.M3ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M3ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M3ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M3ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M3ITXT.MaxLength = 0
        Me.M3ITXT.Name = "M3ITXT"
        Me.M3ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M3ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M3ITXT.TabIndex = 29
        Me.M3ITXT.Text = "0"
        '
        'H3ITXT
        '
        Me.H3ITXT.AcceptsReturn = True
        Me.H3ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H3ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H3ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H3ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H3ITXT.MaxLength = 0
        Me.H3ITXT.Name = "H3ITXT"
        Me.H3ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H3ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H3ITXT.TabIndex = 28
        Me.H3ITXT.Text = "0"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(56, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(17, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "s:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(32, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(19, 17)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "m:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(17, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "h:"
        '
        'Led3
        '
        Me.Led3.BackColor = System.Drawing.Color.Red
        Me.Led3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led3.Location = New System.Drawing.Point(48, 0)
        Me.Led3.Name = "Led3"
        Me.Led3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led3.Size = New System.Drawing.Size(17, 9)
        Me.Led3.TabIndex = 34
        Me.Led3.Visible = False
        '
        '_Frame2_0
        '
        Me._Frame2_0.BackColor = System.Drawing.Color.Transparent
        Me._Frame2_0.Controls.Add(Me.H2ITXT)
        Me._Frame2_0.Controls.Add(Me.M2ITXT)
        Me._Frame2_0.Controls.Add(Me.S2ITXT)
        Me._Frame2_0.Controls.Add(Me.H2FTXT)
        Me._Frame2_0.Controls.Add(Me.M2FTXT)
        Me._Frame2_0.Controls.Add(Me.S2FTXT)
        Me._Frame2_0.Controls.Add(Me.Led2)
        Me._Frame2_0.Controls.Add(Me._Label9_0)
        Me._Frame2_0.Controls.Add(Me._Label8_0)
        Me._Frame2_0.Controls.Add(Me._Label7_0)
        Me._Frame2_0.ForeColor = System.Drawing.Color.White
        Me.Frame2.SetIndex(Me._Frame2_0, CType(0, Short))
        Me._Frame2_0.Location = New System.Drawing.Point(192, 59)
        Me._Frame2_0.Name = "_Frame2_0"
        Me._Frame2_0.Padding = New System.Windows.Forms.Padding(0)
        Me._Frame2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Frame2_0.Size = New System.Drawing.Size(89, 89)
        Me._Frame2_0.TabIndex = 14
        Me._Frame2_0.TabStop = False
        Me._Frame2_0.Text = "OUT 2          "
        '
        'H2ITXT
        '
        Me.H2ITXT.AcceptsReturn = True
        Me.H2ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H2ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H2ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H2ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H2ITXT.MaxLength = 0
        Me.H2ITXT.Name = "H2ITXT"
        Me.H2ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H2ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H2ITXT.TabIndex = 20
        Me.H2ITXT.Text = "0"
        '
        'M2ITXT
        '
        Me.M2ITXT.AcceptsReturn = True
        Me.M2ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M2ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M2ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M2ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M2ITXT.MaxLength = 0
        Me.M2ITXT.Name = "M2ITXT"
        Me.M2ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M2ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M2ITXT.TabIndex = 19
        Me.M2ITXT.Text = "0"
        '
        'S2ITXT
        '
        Me.S2ITXT.AcceptsReturn = True
        Me.S2ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S2ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S2ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S2ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S2ITXT.MaxLength = 0
        Me.S2ITXT.Name = "S2ITXT"
        Me.S2ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S2ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S2ITXT.TabIndex = 18
        Me.S2ITXT.Text = "0"
        '
        'H2FTXT
        '
        Me.H2FTXT.AcceptsReturn = True
        Me.H2FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H2FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H2FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H2FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H2FTXT.MaxLength = 0
        Me.H2FTXT.Name = "H2FTXT"
        Me.H2FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H2FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H2FTXT.TabIndex = 17
        Me.H2FTXT.Text = "0"
        '
        'M2FTXT
        '
        Me.M2FTXT.AcceptsReturn = True
        Me.M2FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M2FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M2FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M2FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M2FTXT.MaxLength = 0
        Me.M2FTXT.Name = "M2FTXT"
        Me.M2FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M2FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M2FTXT.TabIndex = 16
        Me.M2FTXT.Text = "0"
        '
        'S2FTXT
        '
        Me.S2FTXT.AcceptsReturn = True
        Me.S2FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S2FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S2FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S2FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S2FTXT.MaxLength = 0
        Me.S2FTXT.Name = "S2FTXT"
        Me.S2FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S2FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S2FTXT.TabIndex = 15
        Me.S2FTXT.Text = "0"
        '
        'Led2
        '
        Me.Led2.BackColor = System.Drawing.Color.Red
        Me.Led2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led2.Location = New System.Drawing.Point(48, 0)
        Me.Led2.Name = "Led2"
        Me.Led2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led2.Size = New System.Drawing.Size(17, 9)
        Me.Led2.TabIndex = 24
        Me.Led2.Visible = False
        '
        '_Label9_0
        '
        Me._Label9_0.BackColor = System.Drawing.Color.Transparent
        Me._Label9_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label9_0.ForeColor = System.Drawing.Color.White
        Me.Label9.SetIndex(Me._Label9_0, CType(0, Short))
        Me._Label9_0.Location = New System.Drawing.Point(8, 16)
        Me._Label9_0.Name = "_Label9_0"
        Me._Label9_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label9_0.Size = New System.Drawing.Size(17, 17)
        Me._Label9_0.TabIndex = 23
        Me._Label9_0.Text = "h:"
        '
        '_Label8_0
        '
        Me._Label8_0.BackColor = System.Drawing.Color.Transparent
        Me._Label8_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label8_0.ForeColor = System.Drawing.Color.White
        Me.Label8.SetIndex(Me._Label8_0, CType(0, Short))
        Me._Label8_0.Location = New System.Drawing.Point(32, 16)
        Me._Label8_0.Name = "_Label8_0"
        Me._Label8_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label8_0.Size = New System.Drawing.Size(19, 17)
        Me._Label8_0.TabIndex = 22
        Me._Label8_0.Text = "m:"
        '
        '_Label7_0
        '
        Me._Label7_0.BackColor = System.Drawing.Color.Transparent
        Me._Label7_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label7_0.ForeColor = System.Drawing.Color.White
        Me.Label7.SetIndex(Me._Label7_0, CType(0, Short))
        Me._Label7_0.Location = New System.Drawing.Point(56, 16)
        Me._Label7_0.Name = "_Label7_0"
        Me._Label7_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label7_0.Size = New System.Drawing.Size(17, 17)
        Me._Label7_0.TabIndex = 21
        Me._Label7_0.Text = "s:"
        '
        'HActualTxt
        '
        Me.HActualTxt.AcceptsReturn = True
        Me.HActualTxt.BackColor = System.Drawing.SystemColors.Window
        Me.HActualTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HActualTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HActualTxt.Location = New System.Drawing.Point(138, 620)
        Me.HActualTxt.MaxLength = 0
        Me.HActualTxt.Name = "HActualTxt"
        Me.HActualTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HActualTxt.Size = New System.Drawing.Size(73, 20)
        Me.HActualTxt.TabIndex = 9
        Me.HActualTxt.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CmdInicio
        '
        Me.CmdInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInicio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdInicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdInicio.Location = New System.Drawing.Point(230, 572)
        Me.CmdInicio.Name = "CmdInicio"
        Me.CmdInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdInicio.Size = New System.Drawing.Size(57, 25)
        Me.CmdInicio.TabIndex = 5
        Me.CmdInicio.Text = "Inicio"
        Me.CmdInicio.UseVisualStyleBackColor = False
        '
        'HCtxt
        '
        Me.HCtxt.AcceptsReturn = True
        Me.HCtxt.BackColor = System.Drawing.SystemColors.Window
        Me.HCtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HCtxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HCtxt.Location = New System.Drawing.Point(138, 596)
        Me.HCtxt.MaxLength = 0
        Me.HCtxt.Name = "HCtxt"
        Me.HCtxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HCtxt.Size = New System.Drawing.Size(73, 20)
        Me.HCtxt.TabIndex = 4
        Me.HCtxt.Text = "0"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.S1FTXT)
        Me.Frame1.Controls.Add(Me.M1FTXT)
        Me.Frame1.Controls.Add(Me.H1FTXT)
        Me.Frame1.Controls.Add(Me.S1ITXT)
        Me.Frame1.Controls.Add(Me.M1ITXT)
        Me.Frame1.Controls.Add(Me.H1ITXT)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Led1)
        Me.Frame1.ForeColor = System.Drawing.Color.White
        Me.Frame1.Location = New System.Drawing.Point(74, 59)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(89, 89)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "OUT 1          "
        '
        'S1FTXT
        '
        Me.S1FTXT.AcceptsReturn = True
        Me.S1FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S1FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S1FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S1FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S1FTXT.MaxLength = 0
        Me.S1FTXT.Name = "S1FTXT"
        Me.S1FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S1FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S1FTXT.TabIndex = 8
        Me.S1FTXT.Text = "0"
        '
        'M1FTXT
        '
        Me.M1FTXT.AcceptsReturn = True
        Me.M1FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M1FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M1FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M1FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M1FTXT.MaxLength = 0
        Me.M1FTXT.Name = "M1FTXT"
        Me.M1FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M1FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M1FTXT.TabIndex = 7
        Me.M1FTXT.Text = "0"
        '
        'H1FTXT
        '
        Me.H1FTXT.AcceptsReturn = True
        Me.H1FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H1FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H1FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H1FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H1FTXT.MaxLength = 0
        Me.H1FTXT.Name = "H1FTXT"
        Me.H1FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H1FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H1FTXT.TabIndex = 6
        Me.H1FTXT.Text = "0"
        '
        'S1ITXT
        '
        Me.S1ITXT.AcceptsReturn = True
        Me.S1ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S1ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S1ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S1ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S1ITXT.MaxLength = 0
        Me.S1ITXT.Name = "S1ITXT"
        Me.S1ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S1ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S1ITXT.TabIndex = 3
        Me.S1ITXT.Text = "0"
        '
        'M1ITXT
        '
        Me.M1ITXT.AcceptsReturn = True
        Me.M1ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M1ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M1ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M1ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M1ITXT.MaxLength = 0
        Me.M1ITXT.Name = "M1ITXT"
        Me.M1ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M1ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M1ITXT.TabIndex = 2
        Me.M1ITXT.Text = "0"
        '
        'H1ITXT
        '
        Me.H1ITXT.AcceptsReturn = True
        Me.H1ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H1ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H1ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H1ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H1ITXT.MaxLength = 0
        Me.H1ITXT.Name = "H1ITXT"
        Me.H1ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H1ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H1ITXT.TabIndex = 1
        Me.H1ITXT.Text = "0"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(56, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "s:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(19, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "m:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "h:"
        '
        'Led1
        '
        Me.Led1.BackColor = System.Drawing.Color.Red
        Me.Led1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led1.Location = New System.Drawing.Point(48, 0)
        Me.Led1.Name = "Led1"
        Me.Led1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led1.Size = New System.Drawing.Size(17, 9)
        Me.Led1.TabIndex = 10
        Me.Led1.Visible = False
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(188, 556)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(17, 17)
        Me.Label40.TabIndex = 101
        Me.Label40.Text = "s:"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(164, 556)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(17, 17)
        Me.Label39.TabIndex = 100
        Me.Label39.Text = "m:"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(140, 556)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(17, 17)
        Me.Label38.TabIndex = 99
        Me.Label38.Text = "h:"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(32, 572)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(109, 17)
        Me.Label35.TabIndex = 96
        Me.Label35.Text = "Repetir todo cada:"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(30, 596)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(113, 17)
        Me.Label36.TabIndex = 97
        Me.Label36.Text = "Hora de comienzo:"
        '
        'Label74
        '
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(19, 210)
        Me.Label74.Name = "Label74"
        Me.Label74.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label74.Size = New System.Drawing.Size(49, 17)
        Me.Label74.TabIndex = 192
        Me.Label74.Text = " Final:"
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label73.ForeColor = System.Drawing.Color.White
        Me.Label73.Location = New System.Drawing.Point(19, 186)
        Me.Label73.Name = "Label73"
        Me.Label73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label73.Size = New System.Drawing.Size(49, 17)
        Me.Label73.TabIndex = 191
        Me.Label73.Text = " Inicio:"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(30, 620)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(113, 17)
        Me.Label37.TabIndex = 98
        Me.Label37.Text = "Tiempo transcurrido:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = " Final:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = " Inicio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.H24ITXT)
        Me.GroupBox1.Controls.Add(Me.M24ITXT)
        Me.GroupBox1.Controls.Add(Me.S24ITXT)
        Me.GroupBox1.Controls.Add(Me.H24FTXT)
        Me.GroupBox1.Controls.Add(Me.M24FTXT)
        Me.GroupBox1.Controls.Add(Me.S24FTXT)
        Me.GroupBox1.Controls.Add(Me.Led24)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(874, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OUT 24          "
        '
        'H24ITXT
        '
        Me.H24ITXT.AcceptsReturn = True
        Me.H24ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H24ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H24ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H24ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H24ITXT.MaxLength = 0
        Me.H24ITXT.Name = "H24ITXT"
        Me.H24ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H24ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H24ITXT.TabIndex = 88
        Me.H24ITXT.Text = "0"
        '
        'M24ITXT
        '
        Me.M24ITXT.AcceptsReturn = True
        Me.M24ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M24ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M24ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M24ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M24ITXT.MaxLength = 0
        Me.M24ITXT.Name = "M24ITXT"
        Me.M24ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M24ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M24ITXT.TabIndex = 87
        Me.M24ITXT.Text = "0"
        '
        'S24ITXT
        '
        Me.S24ITXT.AcceptsReturn = True
        Me.S24ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S24ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S24ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S24ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S24ITXT.MaxLength = 0
        Me.S24ITXT.Name = "S24ITXT"
        Me.S24ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S24ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S24ITXT.TabIndex = 86
        Me.S24ITXT.Text = "0"
        '
        'H24FTXT
        '
        Me.H24FTXT.AcceptsReturn = True
        Me.H24FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H24FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H24FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H24FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H24FTXT.MaxLength = 0
        Me.H24FTXT.Name = "H24FTXT"
        Me.H24FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H24FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H24FTXT.TabIndex = 85
        Me.H24FTXT.Text = "0"
        '
        'M24FTXT
        '
        Me.M24FTXT.AcceptsReturn = True
        Me.M24FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M24FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M24FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M24FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M24FTXT.MaxLength = 0
        Me.M24FTXT.Name = "M24FTXT"
        Me.M24FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M24FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M24FTXT.TabIndex = 84
        Me.M24FTXT.Text = "0"
        '
        'S24FTXT
        '
        Me.S24FTXT.AcceptsReturn = True
        Me.S24FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S24FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S24FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S24FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S24FTXT.MaxLength = 0
        Me.S24FTXT.Name = "S24FTXT"
        Me.S24FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S24FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S24FTXT.TabIndex = 83
        Me.S24FTXT.Text = "0"
        '
        'Led24
        '
        Me.Led24.BackColor = System.Drawing.Color.Red
        Me.Led24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led24.Location = New System.Drawing.Point(48, 0)
        Me.Led24.Name = "Led24"
        Me.Led24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led24.Size = New System.Drawing.Size(17, 9)
        Me.Led24.TabIndex = 92
        Me.Led24.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(17, 17)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "h:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(32, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(19, 17)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "m:"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(56, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(17, 17)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "s:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.H23ITXT)
        Me.GroupBox2.Controls.Add(Me.M23ITXT)
        Me.GroupBox2.Controls.Add(Me.S23ITXT)
        Me.GroupBox2.Controls.Add(Me.H23FTXT)
        Me.GroupBox2.Controls.Add(Me.M23FTXT)
        Me.GroupBox2.Controls.Add(Me.S23FTXT)
        Me.GroupBox2.Controls.Add(Me.Led23)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(763, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox2.TabIndex = 201
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OUT 23          "
        '
        'H23ITXT
        '
        Me.H23ITXT.AcceptsReturn = True
        Me.H23ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H23ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H23ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H23ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H23ITXT.MaxLength = 0
        Me.H23ITXT.Name = "H23ITXT"
        Me.H23ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H23ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H23ITXT.TabIndex = 77
        Me.H23ITXT.Text = "0"
        '
        'M23ITXT
        '
        Me.M23ITXT.AcceptsReturn = True
        Me.M23ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M23ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M23ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M23ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M23ITXT.MaxLength = 0
        Me.M23ITXT.Name = "M23ITXT"
        Me.M23ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M23ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M23ITXT.TabIndex = 76
        Me.M23ITXT.Text = "0"
        '
        'S23ITXT
        '
        Me.S23ITXT.AcceptsReturn = True
        Me.S23ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S23ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S23ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S23ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S23ITXT.MaxLength = 0
        Me.S23ITXT.Name = "S23ITXT"
        Me.S23ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S23ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S23ITXT.TabIndex = 75
        Me.S23ITXT.Text = "0"
        '
        'H23FTXT
        '
        Me.H23FTXT.AcceptsReturn = True
        Me.H23FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H23FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H23FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H23FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H23FTXT.MaxLength = 0
        Me.H23FTXT.Name = "H23FTXT"
        Me.H23FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H23FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H23FTXT.TabIndex = 74
        Me.H23FTXT.Text = "0"
        '
        'M23FTXT
        '
        Me.M23FTXT.AcceptsReturn = True
        Me.M23FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M23FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M23FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M23FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M23FTXT.MaxLength = 0
        Me.M23FTXT.Name = "M23FTXT"
        Me.M23FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M23FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M23FTXT.TabIndex = 73
        Me.M23FTXT.Text = "0"
        '
        'S23FTXT
        '
        Me.S23FTXT.AcceptsReturn = True
        Me.S23FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S23FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S23FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S23FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S23FTXT.MaxLength = 0
        Me.S23FTXT.Name = "S23FTXT"
        Me.S23FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S23FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S23FTXT.TabIndex = 72
        Me.S23FTXT.Text = "0"
        '
        'Led23
        '
        Me.Led23.BackColor = System.Drawing.Color.Red
        Me.Led23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led23.Location = New System.Drawing.Point(48, 0)
        Me.Led23.Name = "Led23"
        Me.Led23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led23.Size = New System.Drawing.Size(17, 9)
        Me.Led23.TabIndex = 81
        Me.Led23.Visible = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(8, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(17, 17)
        Me.Label23.TabIndex = 80
        Me.Label23.Text = "h:"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(32, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(19, 17)
        Me.Label30.TabIndex = 79
        Me.Label30.Text = "m:"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(56, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(17, 17)
        Me.Label34.TabIndex = 78
        Me.Label34.Text = "s:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.S22FTXT)
        Me.GroupBox3.Controls.Add(Me.M22FTXT)
        Me.GroupBox3.Controls.Add(Me.H22FTXT)
        Me.GroupBox3.Controls.Add(Me.S22ITXT)
        Me.GroupBox3.Controls.Add(Me.M22ITXT)
        Me.GroupBox3.Controls.Add(Me.H22ITXT)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Controls.Add(Me.Label52)
        Me.GroupBox3.Controls.Add(Me.Led22)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(650, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox3.TabIndex = 200
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "OUT 22          "
        '
        'S22FTXT
        '
        Me.S22FTXT.AcceptsReturn = True
        Me.S22FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S22FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S22FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S22FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S22FTXT.MaxLength = 0
        Me.S22FTXT.Name = "S22FTXT"
        Me.S22FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S22FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S22FTXT.TabIndex = 66
        Me.S22FTXT.Text = "0"
        '
        'M22FTXT
        '
        Me.M22FTXT.AcceptsReturn = True
        Me.M22FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M22FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M22FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M22FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M22FTXT.MaxLength = 0
        Me.M22FTXT.Name = "M22FTXT"
        Me.M22FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M22FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M22FTXT.TabIndex = 65
        Me.M22FTXT.Text = "0"
        '
        'H22FTXT
        '
        Me.H22FTXT.AcceptsReturn = True
        Me.H22FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H22FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H22FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H22FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H22FTXT.MaxLength = 0
        Me.H22FTXT.Name = "H22FTXT"
        Me.H22FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H22FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H22FTXT.TabIndex = 64
        Me.H22FTXT.Text = "0"
        '
        'S22ITXT
        '
        Me.S22ITXT.AcceptsReturn = True
        Me.S22ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S22ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S22ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S22ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S22ITXT.MaxLength = 0
        Me.S22ITXT.Name = "S22ITXT"
        Me.S22ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S22ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S22ITXT.TabIndex = 63
        Me.S22ITXT.Text = "0"
        '
        'M22ITXT
        '
        Me.M22ITXT.AcceptsReturn = True
        Me.M22ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M22ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M22ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M22ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M22ITXT.MaxLength = 0
        Me.M22ITXT.Name = "M22ITXT"
        Me.M22ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M22ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M22ITXT.TabIndex = 62
        Me.M22ITXT.Text = "0"
        '
        'H22ITXT
        '
        Me.H22ITXT.AcceptsReturn = True
        Me.H22ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H22ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H22ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H22ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H22ITXT.MaxLength = 0
        Me.H22ITXT.Name = "H22ITXT"
        Me.H22ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H22ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H22ITXT.TabIndex = 61
        Me.H22ITXT.Text = "0"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(56, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(17, 17)
        Me.Label44.TabIndex = 70
        Me.Label44.Text = "s:"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(32, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(19, 17)
        Me.Label48.TabIndex = 69
        Me.Label48.Text = "m:"
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(8, 16)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(17, 17)
        Me.Label52.TabIndex = 68
        Me.Label52.Text = "h:"
        '
        'Led22
        '
        Me.Led22.BackColor = System.Drawing.Color.Red
        Me.Led22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led22.Location = New System.Drawing.Point(48, 0)
        Me.Led22.Name = "Led22"
        Me.Led22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led22.Size = New System.Drawing.Size(17, 9)
        Me.Led22.TabIndex = 67
        Me.Led22.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.S21FTXT)
        Me.GroupBox4.Controls.Add(Me.M21FTXT)
        Me.GroupBox4.Controls.Add(Me.H21FTXT)
        Me.GroupBox4.Controls.Add(Me.S21ITXT)
        Me.GroupBox4.Controls.Add(Me.M21ITXT)
        Me.GroupBox4.Controls.Add(Me.H21ITXT)
        Me.GroupBox4.Controls.Add(Me.Label60)
        Me.GroupBox4.Controls.Add(Me.Label64)
        Me.GroupBox4.Controls.Add(Me.Label68)
        Me.GroupBox4.Controls.Add(Me.Led21)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(537, 248)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox4.TabIndex = 199
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OUT 21          "
        '
        'S21FTXT
        '
        Me.S21FTXT.AcceptsReturn = True
        Me.S21FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S21FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S21FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S21FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S21FTXT.MaxLength = 0
        Me.S21FTXT.Name = "S21FTXT"
        Me.S21FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S21FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S21FTXT.TabIndex = 55
        Me.S21FTXT.Text = "0"
        '
        'M21FTXT
        '
        Me.M21FTXT.AcceptsReturn = True
        Me.M21FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M21FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M21FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M21FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M21FTXT.MaxLength = 0
        Me.M21FTXT.Name = "M21FTXT"
        Me.M21FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M21FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M21FTXT.TabIndex = 54
        Me.M21FTXT.Text = "0"
        '
        'H21FTXT
        '
        Me.H21FTXT.AcceptsReturn = True
        Me.H21FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H21FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H21FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H21FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H21FTXT.MaxLength = 0
        Me.H21FTXT.Name = "H21FTXT"
        Me.H21FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H21FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H21FTXT.TabIndex = 53
        Me.H21FTXT.Text = "0"
        '
        'S21ITXT
        '
        Me.S21ITXT.AcceptsReturn = True
        Me.S21ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S21ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S21ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S21ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S21ITXT.MaxLength = 0
        Me.S21ITXT.Name = "S21ITXT"
        Me.S21ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S21ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S21ITXT.TabIndex = 52
        Me.S21ITXT.Text = "0"
        '
        'M21ITXT
        '
        Me.M21ITXT.AcceptsReturn = True
        Me.M21ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M21ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M21ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M21ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M21ITXT.MaxLength = 0
        Me.M21ITXT.Name = "M21ITXT"
        Me.M21ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M21ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M21ITXT.TabIndex = 51
        Me.M21ITXT.Text = "0"
        '
        'H21ITXT
        '
        Me.H21ITXT.AcceptsReturn = True
        Me.H21ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H21ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H21ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H21ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H21ITXT.MaxLength = 0
        Me.H21ITXT.Name = "H21ITXT"
        Me.H21ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H21ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H21ITXT.TabIndex = 50
        Me.H21ITXT.Text = "0"
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(56, 16)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(17, 17)
        Me.Label60.TabIndex = 59
        Me.Label60.Text = "s:"
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label64.ForeColor = System.Drawing.Color.White
        Me.Label64.Location = New System.Drawing.Point(32, 16)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(19, 17)
        Me.Label64.TabIndex = 58
        Me.Label64.Text = "m:"
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label68.ForeColor = System.Drawing.Color.White
        Me.Label68.Location = New System.Drawing.Point(8, 16)
        Me.Label68.Name = "Label68"
        Me.Label68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label68.Size = New System.Drawing.Size(17, 17)
        Me.Label68.TabIndex = 57
        Me.Label68.Text = "h:"
        '
        'Led21
        '
        Me.Led21.BackColor = System.Drawing.Color.Red
        Me.Led21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led21.Location = New System.Drawing.Point(48, 0)
        Me.Led21.Name = "Led21"
        Me.Led21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led21.Size = New System.Drawing.Size(17, 9)
        Me.Led21.TabIndex = 56
        Me.Led21.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.S20FTXT)
        Me.GroupBox5.Controls.Add(Me.M20FTXT)
        Me.GroupBox5.Controls.Add(Me.H20FTXT)
        Me.GroupBox5.Controls.Add(Me.S20ITXT)
        Me.GroupBox5.Controls.Add(Me.M20ITXT)
        Me.GroupBox5.Controls.Add(Me.H20ITXT)
        Me.GroupBox5.Controls.Add(Me.Label75)
        Me.GroupBox5.Controls.Add(Me.Label79)
        Me.GroupBox5.Controls.Add(Me.Label80)
        Me.GroupBox5.Controls.Add(Me.Led20)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(424, 248)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox5.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox5.TabIndex = 198
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OUT 20          "
        '
        'S20FTXT
        '
        Me.S20FTXT.AcceptsReturn = True
        Me.S20FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S20FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S20FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S20FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S20FTXT.MaxLength = 0
        Me.S20FTXT.Name = "S20FTXT"
        Me.S20FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S20FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S20FTXT.TabIndex = 44
        Me.S20FTXT.Text = "0"
        '
        'M20FTXT
        '
        Me.M20FTXT.AcceptsReturn = True
        Me.M20FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M20FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M20FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M20FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M20FTXT.MaxLength = 0
        Me.M20FTXT.Name = "M20FTXT"
        Me.M20FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M20FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M20FTXT.TabIndex = 43
        Me.M20FTXT.Text = "0"
        '
        'H20FTXT
        '
        Me.H20FTXT.AcceptsReturn = True
        Me.H20FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H20FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H20FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H20FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H20FTXT.MaxLength = 0
        Me.H20FTXT.Name = "H20FTXT"
        Me.H20FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H20FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H20FTXT.TabIndex = 42
        Me.H20FTXT.Text = "0"
        '
        'S20ITXT
        '
        Me.S20ITXT.AcceptsReturn = True
        Me.S20ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S20ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S20ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S20ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S20ITXT.MaxLength = 0
        Me.S20ITXT.Name = "S20ITXT"
        Me.S20ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S20ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S20ITXT.TabIndex = 41
        Me.S20ITXT.Text = "0"
        '
        'M20ITXT
        '
        Me.M20ITXT.AcceptsReturn = True
        Me.M20ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M20ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M20ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M20ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M20ITXT.MaxLength = 0
        Me.M20ITXT.Name = "M20ITXT"
        Me.M20ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M20ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M20ITXT.TabIndex = 40
        Me.M20ITXT.Text = "0"
        '
        'H20ITXT
        '
        Me.H20ITXT.AcceptsReturn = True
        Me.H20ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H20ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H20ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H20ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H20ITXT.MaxLength = 0
        Me.H20ITXT.Name = "H20ITXT"
        Me.H20ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H20ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H20ITXT.TabIndex = 39
        Me.H20ITXT.Text = "0"
        '
        'Label75
        '
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label75.ForeColor = System.Drawing.Color.White
        Me.Label75.Location = New System.Drawing.Point(56, 16)
        Me.Label75.Name = "Label75"
        Me.Label75.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label75.Size = New System.Drawing.Size(17, 17)
        Me.Label75.TabIndex = 48
        Me.Label75.Text = "s:"
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label79.ForeColor = System.Drawing.Color.White
        Me.Label79.Location = New System.Drawing.Point(32, 16)
        Me.Label79.Name = "Label79"
        Me.Label79.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label79.Size = New System.Drawing.Size(19, 17)
        Me.Label79.TabIndex = 47
        Me.Label79.Text = "m:"
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label80.ForeColor = System.Drawing.Color.White
        Me.Label80.Location = New System.Drawing.Point(8, 16)
        Me.Label80.Name = "Label80"
        Me.Label80.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label80.Size = New System.Drawing.Size(17, 17)
        Me.Label80.TabIndex = 46
        Me.Label80.Text = "h:"
        '
        'Led20
        '
        Me.Led20.BackColor = System.Drawing.Color.Red
        Me.Led20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led20.Location = New System.Drawing.Point(48, 0)
        Me.Led20.Name = "Led20"
        Me.Led20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led20.Size = New System.Drawing.Size(17, 9)
        Me.Led20.TabIndex = 45
        Me.Led20.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.S19FTXT)
        Me.GroupBox6.Controls.Add(Me.M19FTXT)
        Me.GroupBox6.Controls.Add(Me.H19FTXT)
        Me.GroupBox6.Controls.Add(Me.S19ITXT)
        Me.GroupBox6.Controls.Add(Me.M19ITXT)
        Me.GroupBox6.Controls.Add(Me.H19ITXT)
        Me.GroupBox6.Controls.Add(Me.Label82)
        Me.GroupBox6.Controls.Add(Me.Label83)
        Me.GroupBox6.Controls.Add(Me.Label84)
        Me.GroupBox6.Controls.Add(Me.Led19)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(310, 248)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox6.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox6.TabIndex = 197
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "OUT 19          "
        '
        'S19FTXT
        '
        Me.S19FTXT.AcceptsReturn = True
        Me.S19FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S19FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S19FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S19FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S19FTXT.MaxLength = 0
        Me.S19FTXT.Name = "S19FTXT"
        Me.S19FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S19FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S19FTXT.TabIndex = 33
        Me.S19FTXT.Text = "0"
        '
        'M19FTXT
        '
        Me.M19FTXT.AcceptsReturn = True
        Me.M19FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M19FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M19FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M19FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M19FTXT.MaxLength = 0
        Me.M19FTXT.Name = "M19FTXT"
        Me.M19FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M19FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M19FTXT.TabIndex = 32
        Me.M19FTXT.Text = "0"
        '
        'H19FTXT
        '
        Me.H19FTXT.AcceptsReturn = True
        Me.H19FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H19FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H19FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H19FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H19FTXT.MaxLength = 0
        Me.H19FTXT.Name = "H19FTXT"
        Me.H19FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H19FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H19FTXT.TabIndex = 31
        Me.H19FTXT.Text = "0"
        '
        'S19ITXT
        '
        Me.S19ITXT.AcceptsReturn = True
        Me.S19ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S19ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S19ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S19ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S19ITXT.MaxLength = 0
        Me.S19ITXT.Name = "S19ITXT"
        Me.S19ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S19ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S19ITXT.TabIndex = 30
        Me.S19ITXT.Text = "0"
        '
        'M19ITXT
        '
        Me.M19ITXT.AcceptsReturn = True
        Me.M19ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M19ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M19ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M19ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M19ITXT.MaxLength = 0
        Me.M19ITXT.Name = "M19ITXT"
        Me.M19ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M19ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M19ITXT.TabIndex = 29
        Me.M19ITXT.Text = "0"
        '
        'H19ITXT
        '
        Me.H19ITXT.AcceptsReturn = True
        Me.H19ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H19ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H19ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H19ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H19ITXT.MaxLength = 0
        Me.H19ITXT.Name = "H19ITXT"
        Me.H19ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H19ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H19ITXT.TabIndex = 28
        Me.H19ITXT.Text = "0"
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label82.ForeColor = System.Drawing.Color.White
        Me.Label82.Location = New System.Drawing.Point(56, 16)
        Me.Label82.Name = "Label82"
        Me.Label82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label82.Size = New System.Drawing.Size(17, 17)
        Me.Label82.TabIndex = 37
        Me.Label82.Text = "s:"
        '
        'Label83
        '
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label83.ForeColor = System.Drawing.Color.White
        Me.Label83.Location = New System.Drawing.Point(32, 16)
        Me.Label83.Name = "Label83"
        Me.Label83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label83.Size = New System.Drawing.Size(19, 17)
        Me.Label83.TabIndex = 36
        Me.Label83.Text = "m:"
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label84.ForeColor = System.Drawing.Color.White
        Me.Label84.Location = New System.Drawing.Point(8, 16)
        Me.Label84.Name = "Label84"
        Me.Label84.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label84.Size = New System.Drawing.Size(17, 17)
        Me.Label84.TabIndex = 35
        Me.Label84.Text = "h:"
        '
        'Led19
        '
        Me.Led19.BackColor = System.Drawing.Color.Red
        Me.Led19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led19.Location = New System.Drawing.Point(48, 0)
        Me.Led19.Name = "Led19"
        Me.Led19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led19.Size = New System.Drawing.Size(17, 9)
        Me.Led19.TabIndex = 34
        Me.Led19.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.H18ITXT)
        Me.GroupBox7.Controls.Add(Me.M18ITXT)
        Me.GroupBox7.Controls.Add(Me.S18ITXT)
        Me.GroupBox7.Controls.Add(Me.H18FTXT)
        Me.GroupBox7.Controls.Add(Me.M18FTXT)
        Me.GroupBox7.Controls.Add(Me.S18FTXT)
        Me.GroupBox7.Controls.Add(Me.Led18)
        Me.GroupBox7.Controls.Add(Me.Label87)
        Me.GroupBox7.Controls.Add(Me.Label88)
        Me.GroupBox7.Controls.Add(Me.Label89)
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(194, 248)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox7.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox7.TabIndex = 194
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "OUT 18          "
        '
        'H18ITXT
        '
        Me.H18ITXT.AcceptsReturn = True
        Me.H18ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H18ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H18ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H18ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H18ITXT.MaxLength = 0
        Me.H18ITXT.Name = "H18ITXT"
        Me.H18ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H18ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H18ITXT.TabIndex = 20
        Me.H18ITXT.Text = "0"
        '
        'M18ITXT
        '
        Me.M18ITXT.AcceptsReturn = True
        Me.M18ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M18ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M18ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M18ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M18ITXT.MaxLength = 0
        Me.M18ITXT.Name = "M18ITXT"
        Me.M18ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M18ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M18ITXT.TabIndex = 19
        Me.M18ITXT.Text = "0"
        '
        'S18ITXT
        '
        Me.S18ITXT.AcceptsReturn = True
        Me.S18ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S18ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S18ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S18ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S18ITXT.MaxLength = 0
        Me.S18ITXT.Name = "S18ITXT"
        Me.S18ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S18ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S18ITXT.TabIndex = 18
        Me.S18ITXT.Text = "0"
        '
        'H18FTXT
        '
        Me.H18FTXT.AcceptsReturn = True
        Me.H18FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H18FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H18FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H18FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H18FTXT.MaxLength = 0
        Me.H18FTXT.Name = "H18FTXT"
        Me.H18FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H18FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H18FTXT.TabIndex = 17
        Me.H18FTXT.Text = "0"
        '
        'M18FTXT
        '
        Me.M18FTXT.AcceptsReturn = True
        Me.M18FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M18FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M18FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M18FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M18FTXT.MaxLength = 0
        Me.M18FTXT.Name = "M18FTXT"
        Me.M18FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M18FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M18FTXT.TabIndex = 16
        Me.M18FTXT.Text = "0"
        '
        'S18FTXT
        '
        Me.S18FTXT.AcceptsReturn = True
        Me.S18FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S18FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S18FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S18FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S18FTXT.MaxLength = 0
        Me.S18FTXT.Name = "S18FTXT"
        Me.S18FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S18FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S18FTXT.TabIndex = 15
        Me.S18FTXT.Text = "0"
        '
        'Led18
        '
        Me.Led18.BackColor = System.Drawing.Color.Red
        Me.Led18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led18.Location = New System.Drawing.Point(48, 0)
        Me.Led18.Name = "Led18"
        Me.Led18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led18.Size = New System.Drawing.Size(17, 9)
        Me.Led18.TabIndex = 24
        Me.Led18.Visible = False
        '
        'Label87
        '
        Me.Label87.BackColor = System.Drawing.Color.Transparent
        Me.Label87.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label87.ForeColor = System.Drawing.Color.White
        Me.Label87.Location = New System.Drawing.Point(8, 16)
        Me.Label87.Name = "Label87"
        Me.Label87.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label87.Size = New System.Drawing.Size(17, 17)
        Me.Label87.TabIndex = 23
        Me.Label87.Text = "h:"
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label88.ForeColor = System.Drawing.Color.White
        Me.Label88.Location = New System.Drawing.Point(32, 16)
        Me.Label88.Name = "Label88"
        Me.Label88.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label88.Size = New System.Drawing.Size(19, 17)
        Me.Label88.TabIndex = 22
        Me.Label88.Text = "m:"
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label89.ForeColor = System.Drawing.Color.White
        Me.Label89.Location = New System.Drawing.Point(56, 16)
        Me.Label89.Name = "Label89"
        Me.Label89.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label89.Size = New System.Drawing.Size(17, 17)
        Me.Label89.TabIndex = 21
        Me.Label89.Text = "s:"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.S17FTXT)
        Me.GroupBox8.Controls.Add(Me.M17FTXT)
        Me.GroupBox8.Controls.Add(Me.H17FTXT)
        Me.GroupBox8.Controls.Add(Me.S17ITXT)
        Me.GroupBox8.Controls.Add(Me.M17ITXT)
        Me.GroupBox8.Controls.Add(Me.H17ITXT)
        Me.GroupBox8.Controls.Add(Me.Label90)
        Me.GroupBox8.Controls.Add(Me.Label91)
        Me.GroupBox8.Controls.Add(Me.Label92)
        Me.GroupBox8.Controls.Add(Me.Led17)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(76, 248)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox8.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox8.TabIndex = 193
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "OUT 17          "
        '
        'S17FTXT
        '
        Me.S17FTXT.AcceptsReturn = True
        Me.S17FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S17FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S17FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S17FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S17FTXT.MaxLength = 0
        Me.S17FTXT.Name = "S17FTXT"
        Me.S17FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S17FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S17FTXT.TabIndex = 8
        Me.S17FTXT.Text = "0"
        '
        'M17FTXT
        '
        Me.M17FTXT.AcceptsReturn = True
        Me.M17FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M17FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M17FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M17FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M17FTXT.MaxLength = 0
        Me.M17FTXT.Name = "M17FTXT"
        Me.M17FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M17FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M17FTXT.TabIndex = 7
        Me.M17FTXT.Text = "0"
        '
        'H17FTXT
        '
        Me.H17FTXT.AcceptsReturn = True
        Me.H17FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H17FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H17FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H17FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H17FTXT.MaxLength = 0
        Me.H17FTXT.Name = "H17FTXT"
        Me.H17FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H17FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H17FTXT.TabIndex = 6
        Me.H17FTXT.Text = "0"
        '
        'S17ITXT
        '
        Me.S17ITXT.AcceptsReturn = True
        Me.S17ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S17ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S17ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S17ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S17ITXT.MaxLength = 0
        Me.S17ITXT.Name = "S17ITXT"
        Me.S17ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S17ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S17ITXT.TabIndex = 3
        Me.S17ITXT.Text = "0"
        '
        'M17ITXT
        '
        Me.M17ITXT.AcceptsReturn = True
        Me.M17ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M17ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M17ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M17ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M17ITXT.MaxLength = 0
        Me.M17ITXT.Name = "M17ITXT"
        Me.M17ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M17ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M17ITXT.TabIndex = 2
        Me.M17ITXT.Text = "0"
        '
        'H17ITXT
        '
        Me.H17ITXT.AcceptsReturn = True
        Me.H17ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H17ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H17ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H17ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H17ITXT.MaxLength = 0
        Me.H17ITXT.Name = "H17ITXT"
        Me.H17ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H17ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H17ITXT.TabIndex = 1
        Me.H17ITXT.Text = "0"
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label90.ForeColor = System.Drawing.Color.White
        Me.Label90.Location = New System.Drawing.Point(56, 16)
        Me.Label90.Name = "Label90"
        Me.Label90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label90.Size = New System.Drawing.Size(25, 17)
        Me.Label90.TabIndex = 13
        Me.Label90.Text = "s:"
        '
        'Label91
        '
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label91.ForeColor = System.Drawing.Color.White
        Me.Label91.Location = New System.Drawing.Point(32, 16)
        Me.Label91.Name = "Label91"
        Me.Label91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label91.Size = New System.Drawing.Size(19, 17)
        Me.Label91.TabIndex = 12
        Me.Label91.Text = "m:"
        '
        'Label92
        '
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label92.ForeColor = System.Drawing.Color.White
        Me.Label92.Location = New System.Drawing.Point(8, 16)
        Me.Label92.Name = "Label92"
        Me.Label92.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label92.Size = New System.Drawing.Size(17, 17)
        Me.Label92.TabIndex = 11
        Me.Label92.Text = "h:"
        '
        'Led17
        '
        Me.Led17.BackColor = System.Drawing.Color.Red
        Me.Led17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led17.Location = New System.Drawing.Point(48, 0)
        Me.Led17.Name = "Led17"
        Me.Led17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led17.Size = New System.Drawing.Size(17, 9)
        Me.Led17.TabIndex = 10
        Me.Led17.Visible = False
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label94.ForeColor = System.Drawing.Color.White
        Me.Label94.Location = New System.Drawing.Point(20, 304)
        Me.Label94.Name = "Label94"
        Me.Label94.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label94.Size = New System.Drawing.Size(49, 17)
        Me.Label94.TabIndex = 196
        Me.Label94.Text = " Final:"
        '
        'Label95
        '
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label95.ForeColor = System.Drawing.Color.White
        Me.Label95.Location = New System.Drawing.Point(20, 280)
        Me.Label95.Name = "Label95"
        Me.Label95.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label95.Size = New System.Drawing.Size(49, 17)
        Me.Label95.TabIndex = 195
        Me.Label95.Text = " Inicio:"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.S29FTXT)
        Me.GroupBox9.Controls.Add(Me.M29FTXT)
        Me.GroupBox9.Controls.Add(Me.H29FTXT)
        Me.GroupBox9.Controls.Add(Me.S29ITXT)
        Me.GroupBox9.Controls.Add(Me.M29ITXT)
        Me.GroupBox9.Controls.Add(Me.H29ITXT)
        Me.GroupBox9.Controls.Add(Me.S29)
        Me.GroupBox9.Controls.Add(Me.M29)
        Me.GroupBox9.Controls.Add(Me.H29)
        Me.GroupBox9.Controls.Add(Me.Led29)
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(537, 347)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox9.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox9.TabIndex = 209
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "OUT 29         "
        '
        'S29FTXT
        '
        Me.S29FTXT.AcceptsReturn = True
        Me.S29FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S29FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S29FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S29FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S29FTXT.MaxLength = 0
        Me.S29FTXT.Name = "S29FTXT"
        Me.S29FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S29FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S29FTXT.TabIndex = 55
        Me.S29FTXT.Text = "0"
        '
        'M29FTXT
        '
        Me.M29FTXT.AcceptsReturn = True
        Me.M29FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M29FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M29FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M29FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M29FTXT.MaxLength = 0
        Me.M29FTXT.Name = "M29FTXT"
        Me.M29FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M29FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M29FTXT.TabIndex = 54
        Me.M29FTXT.Text = "0"
        '
        'H29FTXT
        '
        Me.H29FTXT.AcceptsReturn = True
        Me.H29FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H29FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H29FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H29FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H29FTXT.MaxLength = 0
        Me.H29FTXT.Name = "H29FTXT"
        Me.H29FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H29FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H29FTXT.TabIndex = 53
        Me.H29FTXT.Text = "0"
        '
        'S29ITXT
        '
        Me.S29ITXT.AcceptsReturn = True
        Me.S29ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S29ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S29ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S29ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S29ITXT.MaxLength = 0
        Me.S29ITXT.Name = "S29ITXT"
        Me.S29ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S29ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S29ITXT.TabIndex = 52
        Me.S29ITXT.Text = "0"
        '
        'M29ITXT
        '
        Me.M29ITXT.AcceptsReturn = True
        Me.M29ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M29ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M29ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M29ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M29ITXT.MaxLength = 0
        Me.M29ITXT.Name = "M29ITXT"
        Me.M29ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M29ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M29ITXT.TabIndex = 51
        Me.M29ITXT.Text = "0"
        '
        'H29ITXT
        '
        Me.H29ITXT.AcceptsReturn = True
        Me.H29ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H29ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H29ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H29ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H29ITXT.MaxLength = 0
        Me.H29ITXT.Name = "H29ITXT"
        Me.H29ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H29ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H29ITXT.TabIndex = 50
        Me.H29ITXT.Text = "0"
        '
        'S29
        '
        Me.S29.BackColor = System.Drawing.Color.Transparent
        Me.S29.Cursor = System.Windows.Forms.Cursors.Default
        Me.S29.ForeColor = System.Drawing.Color.White
        Me.S29.Location = New System.Drawing.Point(56, 16)
        Me.S29.Name = "S29"
        Me.S29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S29.Size = New System.Drawing.Size(17, 17)
        Me.S29.TabIndex = 59
        Me.S29.Text = "s:"
        '
        'M29
        '
        Me.M29.BackColor = System.Drawing.Color.Transparent
        Me.M29.Cursor = System.Windows.Forms.Cursors.Default
        Me.M29.ForeColor = System.Drawing.Color.White
        Me.M29.Location = New System.Drawing.Point(32, 16)
        Me.M29.Name = "M29"
        Me.M29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M29.Size = New System.Drawing.Size(19, 17)
        Me.M29.TabIndex = 58
        Me.M29.Text = "m:"
        '
        'H29
        '
        Me.H29.BackColor = System.Drawing.Color.Transparent
        Me.H29.Cursor = System.Windows.Forms.Cursors.Default
        Me.H29.ForeColor = System.Drawing.Color.White
        Me.H29.Location = New System.Drawing.Point(8, 16)
        Me.H29.Name = "H29"
        Me.H29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H29.Size = New System.Drawing.Size(17, 17)
        Me.H29.TabIndex = 57
        Me.H29.Text = "h:"
        '
        'Led29
        '
        Me.Led29.BackColor = System.Drawing.Color.Red
        Me.Led29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led29.Location = New System.Drawing.Point(48, 0)
        Me.Led29.Name = "Led29"
        Me.Led29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led29.Size = New System.Drawing.Size(17, 9)
        Me.Led29.TabIndex = 56
        Me.Led29.Visible = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.S28FTXT)
        Me.GroupBox10.Controls.Add(Me.M28FTXT)
        Me.GroupBox10.Controls.Add(Me.H28FTXT)
        Me.GroupBox10.Controls.Add(Me.S28ITXT)
        Me.GroupBox10.Controls.Add(Me.M28ITXT)
        Me.GroupBox10.Controls.Add(Me.H28ITXT)
        Me.GroupBox10.Controls.Add(Me.S28)
        Me.GroupBox10.Controls.Add(Me.M28)
        Me.GroupBox10.Controls.Add(Me.H28)
        Me.GroupBox10.Controls.Add(Me.Led28)
        Me.GroupBox10.ForeColor = System.Drawing.Color.White
        Me.GroupBox10.Location = New System.Drawing.Point(424, 347)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox10.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox10.TabIndex = 208
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "OUT 28          "
        '
        'S28FTXT
        '
        Me.S28FTXT.AcceptsReturn = True
        Me.S28FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S28FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S28FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S28FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S28FTXT.MaxLength = 0
        Me.S28FTXT.Name = "S28FTXT"
        Me.S28FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S28FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S28FTXT.TabIndex = 44
        Me.S28FTXT.Text = "0"
        '
        'M28FTXT
        '
        Me.M28FTXT.AcceptsReturn = True
        Me.M28FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M28FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M28FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M28FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M28FTXT.MaxLength = 0
        Me.M28FTXT.Name = "M28FTXT"
        Me.M28FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M28FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M28FTXT.TabIndex = 43
        Me.M28FTXT.Text = "0"
        '
        'H28FTXT
        '
        Me.H28FTXT.AcceptsReturn = True
        Me.H28FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H28FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H28FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H28FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H28FTXT.MaxLength = 0
        Me.H28FTXT.Name = "H28FTXT"
        Me.H28FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H28FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H28FTXT.TabIndex = 42
        Me.H28FTXT.Text = "0"
        '
        'S28ITXT
        '
        Me.S28ITXT.AcceptsReturn = True
        Me.S28ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S28ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S28ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S28ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S28ITXT.MaxLength = 0
        Me.S28ITXT.Name = "S28ITXT"
        Me.S28ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S28ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S28ITXT.TabIndex = 21
        Me.S28ITXT.Text = "0"
        '
        'M28ITXT
        '
        Me.M28ITXT.AcceptsReturn = True
        Me.M28ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M28ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M28ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M28ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M28ITXT.MaxLength = 0
        Me.M28ITXT.Name = "M28ITXT"
        Me.M28ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M28ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M28ITXT.TabIndex = 40
        Me.M28ITXT.Text = "0"
        '
        'H28ITXT
        '
        Me.H28ITXT.AcceptsReturn = True
        Me.H28ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H28ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H28ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H28ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H28ITXT.MaxLength = 0
        Me.H28ITXT.Name = "H28ITXT"
        Me.H28ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H28ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H28ITXT.TabIndex = 39
        Me.H28ITXT.Text = "0"
        '
        'S28
        '
        Me.S28.BackColor = System.Drawing.Color.Transparent
        Me.S28.Cursor = System.Windows.Forms.Cursors.Default
        Me.S28.ForeColor = System.Drawing.Color.White
        Me.S28.Location = New System.Drawing.Point(56, 16)
        Me.S28.Name = "S28"
        Me.S28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S28.Size = New System.Drawing.Size(17, 17)
        Me.S28.TabIndex = 48
        Me.S28.Text = "s:"
        '
        'M28
        '
        Me.M28.BackColor = System.Drawing.Color.Transparent
        Me.M28.Cursor = System.Windows.Forms.Cursors.Default
        Me.M28.ForeColor = System.Drawing.Color.White
        Me.M28.Location = New System.Drawing.Point(32, 16)
        Me.M28.Name = "M28"
        Me.M28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M28.Size = New System.Drawing.Size(19, 17)
        Me.M28.TabIndex = 47
        Me.M28.Text = "m:"
        '
        'H28
        '
        Me.H28.BackColor = System.Drawing.Color.Transparent
        Me.H28.Cursor = System.Windows.Forms.Cursors.Default
        Me.H28.ForeColor = System.Drawing.Color.White
        Me.H28.Location = New System.Drawing.Point(8, 16)
        Me.H28.Name = "H28"
        Me.H28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H28.Size = New System.Drawing.Size(17, 17)
        Me.H28.TabIndex = 46
        Me.H28.Text = "h:"
        '
        'Led28
        '
        Me.Led28.BackColor = System.Drawing.Color.Red
        Me.Led28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led28.Location = New System.Drawing.Point(48, 0)
        Me.Led28.Name = "Led28"
        Me.Led28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led28.Size = New System.Drawing.Size(17, 9)
        Me.Led28.TabIndex = 45
        Me.Led28.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.S27FTXT)
        Me.GroupBox11.Controls.Add(Me.M27FTXT)
        Me.GroupBox11.Controls.Add(Me.H27FTXT)
        Me.GroupBox11.Controls.Add(Me.S27ITXT)
        Me.GroupBox11.Controls.Add(Me.M27ITXT)
        Me.GroupBox11.Controls.Add(Me.H27ITXT)
        Me.GroupBox11.Controls.Add(Me.S27)
        Me.GroupBox11.Controls.Add(Me.M27)
        Me.GroupBox11.Controls.Add(Me.H27)
        Me.GroupBox11.Controls.Add(Me.Led27)
        Me.GroupBox11.ForeColor = System.Drawing.Color.White
        Me.GroupBox11.Location = New System.Drawing.Point(310, 347)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox11.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox11.TabIndex = 207
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "OUT 27          "
        '
        'S27FTXT
        '
        Me.S27FTXT.AcceptsReturn = True
        Me.S27FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S27FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S27FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S27FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S27FTXT.MaxLength = 0
        Me.S27FTXT.Name = "S27FTXT"
        Me.S27FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S27FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S27FTXT.TabIndex = 33
        Me.S27FTXT.Text = "0"
        '
        'M27FTXT
        '
        Me.M27FTXT.AcceptsReturn = True
        Me.M27FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M27FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M27FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M27FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M27FTXT.MaxLength = 0
        Me.M27FTXT.Name = "M27FTXT"
        Me.M27FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M27FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M27FTXT.TabIndex = 32
        Me.M27FTXT.Text = "0"
        '
        'H27FTXT
        '
        Me.H27FTXT.AcceptsReturn = True
        Me.H27FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H27FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H27FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H27FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H27FTXT.MaxLength = 0
        Me.H27FTXT.Name = "H27FTXT"
        Me.H27FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H27FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H27FTXT.TabIndex = 31
        Me.H27FTXT.Text = "0"
        '
        'S27ITXT
        '
        Me.S27ITXT.AcceptsReturn = True
        Me.S27ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S27ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S27ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S27ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S27ITXT.MaxLength = 0
        Me.S27ITXT.Name = "S27ITXT"
        Me.S27ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S27ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S27ITXT.TabIndex = 30
        Me.S27ITXT.Text = "0"
        '
        'M27ITXT
        '
        Me.M27ITXT.AcceptsReturn = True
        Me.M27ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M27ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M27ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M27ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M27ITXT.MaxLength = 0
        Me.M27ITXT.Name = "M27ITXT"
        Me.M27ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M27ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M27ITXT.TabIndex = 29
        Me.M27ITXT.Text = "0"
        '
        'H27ITXT
        '
        Me.H27ITXT.AcceptsReturn = True
        Me.H27ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H27ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H27ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H27ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H27ITXT.MaxLength = 0
        Me.H27ITXT.Name = "H27ITXT"
        Me.H27ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H27ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H27ITXT.TabIndex = 28
        Me.H27ITXT.Text = "0"
        '
        'S27
        '
        Me.S27.BackColor = System.Drawing.Color.Transparent
        Me.S27.Cursor = System.Windows.Forms.Cursors.Default
        Me.S27.ForeColor = System.Drawing.Color.White
        Me.S27.Location = New System.Drawing.Point(56, 16)
        Me.S27.Name = "S27"
        Me.S27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S27.Size = New System.Drawing.Size(17, 17)
        Me.S27.TabIndex = 37
        Me.S27.Text = "s:"
        '
        'M27
        '
        Me.M27.BackColor = System.Drawing.Color.Transparent
        Me.M27.Cursor = System.Windows.Forms.Cursors.Default
        Me.M27.ForeColor = System.Drawing.Color.White
        Me.M27.Location = New System.Drawing.Point(32, 16)
        Me.M27.Name = "M27"
        Me.M27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M27.Size = New System.Drawing.Size(19, 17)
        Me.M27.TabIndex = 36
        Me.M27.Text = "m:"
        '
        'H27
        '
        Me.H27.BackColor = System.Drawing.Color.Transparent
        Me.H27.Cursor = System.Windows.Forms.Cursors.Default
        Me.H27.ForeColor = System.Drawing.Color.White
        Me.H27.Location = New System.Drawing.Point(8, 16)
        Me.H27.Name = "H27"
        Me.H27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H27.Size = New System.Drawing.Size(17, 17)
        Me.H27.TabIndex = 35
        Me.H27.Text = "h:"
        '
        'Led27
        '
        Me.Led27.BackColor = System.Drawing.Color.Red
        Me.Led27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led27.Location = New System.Drawing.Point(48, 0)
        Me.Led27.Name = "Led27"
        Me.Led27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led27.Size = New System.Drawing.Size(17, 9)
        Me.Led27.TabIndex = 34
        Me.Led27.Visible = False
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox12.Controls.Add(Me.H26ITXT)
        Me.GroupBox12.Controls.Add(Me.M26ITXT)
        Me.GroupBox12.Controls.Add(Me.S26ITXT)
        Me.GroupBox12.Controls.Add(Me.H26FTXT)
        Me.GroupBox12.Controls.Add(Me.M26FTXT)
        Me.GroupBox12.Controls.Add(Me.S26FTXT)
        Me.GroupBox12.Controls.Add(Me.Led26)
        Me.GroupBox12.Controls.Add(Me.H26)
        Me.GroupBox12.Controls.Add(Me.M26)
        Me.GroupBox12.Controls.Add(Me.S26)
        Me.GroupBox12.ForeColor = System.Drawing.Color.White
        Me.GroupBox12.Location = New System.Drawing.Point(194, 347)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox12.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox12.TabIndex = 204
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "OUT 26         "
        '
        'H26ITXT
        '
        Me.H26ITXT.AcceptsReturn = True
        Me.H26ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H26ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H26ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H26ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H26ITXT.MaxLength = 0
        Me.H26ITXT.Name = "H26ITXT"
        Me.H26ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H26ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H26ITXT.TabIndex = 20
        Me.H26ITXT.Text = "0"
        '
        'M26ITXT
        '
        Me.M26ITXT.AcceptsReturn = True
        Me.M26ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M26ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M26ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M26ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M26ITXT.MaxLength = 0
        Me.M26ITXT.Name = "M26ITXT"
        Me.M26ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M26ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M26ITXT.TabIndex = 19
        Me.M26ITXT.Text = "0"
        '
        'S26ITXT
        '
        Me.S26ITXT.AcceptsReturn = True
        Me.S26ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S26ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S26ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S26ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S26ITXT.MaxLength = 0
        Me.S26ITXT.Name = "S26ITXT"
        Me.S26ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S26ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S26ITXT.TabIndex = 18
        Me.S26ITXT.Text = "0"
        '
        'H26FTXT
        '
        Me.H26FTXT.AcceptsReturn = True
        Me.H26FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H26FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H26FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H26FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H26FTXT.MaxLength = 0
        Me.H26FTXT.Name = "H26FTXT"
        Me.H26FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H26FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H26FTXT.TabIndex = 17
        Me.H26FTXT.Text = "0"
        '
        'M26FTXT
        '
        Me.M26FTXT.AcceptsReturn = True
        Me.M26FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M26FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M26FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M26FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M26FTXT.MaxLength = 0
        Me.M26FTXT.Name = "M26FTXT"
        Me.M26FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M26FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M26FTXT.TabIndex = 16
        Me.M26FTXT.Text = "0"
        '
        'S26FTXT
        '
        Me.S26FTXT.AcceptsReturn = True
        Me.S26FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S26FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S26FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S26FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S26FTXT.MaxLength = 0
        Me.S26FTXT.Name = "S26FTXT"
        Me.S26FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S26FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S26FTXT.TabIndex = 15
        Me.S26FTXT.Text = "0"
        '
        'Led26
        '
        Me.Led26.BackColor = System.Drawing.Color.Red
        Me.Led26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led26.Location = New System.Drawing.Point(48, 0)
        Me.Led26.Name = "Led26"
        Me.Led26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led26.Size = New System.Drawing.Size(17, 9)
        Me.Led26.TabIndex = 24
        Me.Led26.Visible = False
        '
        'H26
        '
        Me.H26.BackColor = System.Drawing.Color.Transparent
        Me.H26.Cursor = System.Windows.Forms.Cursors.Default
        Me.H26.ForeColor = System.Drawing.Color.White
        Me.H26.Location = New System.Drawing.Point(8, 16)
        Me.H26.Name = "H26"
        Me.H26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H26.Size = New System.Drawing.Size(17, 17)
        Me.H26.TabIndex = 23
        Me.H26.Text = "h:"
        '
        'M26
        '
        Me.M26.BackColor = System.Drawing.Color.Transparent
        Me.M26.Cursor = System.Windows.Forms.Cursors.Default
        Me.M26.ForeColor = System.Drawing.Color.White
        Me.M26.Location = New System.Drawing.Point(32, 16)
        Me.M26.Name = "M26"
        Me.M26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M26.Size = New System.Drawing.Size(19, 17)
        Me.M26.TabIndex = 22
        Me.M26.Text = "m:"
        '
        'S26
        '
        Me.S26.BackColor = System.Drawing.Color.Transparent
        Me.S26.Cursor = System.Windows.Forms.Cursors.Default
        Me.S26.ForeColor = System.Drawing.Color.White
        Me.S26.Location = New System.Drawing.Point(56, 16)
        Me.S26.Name = "S26"
        Me.S26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S26.Size = New System.Drawing.Size(17, 17)
        Me.S26.TabIndex = 21
        Me.S26.Text = "s:"
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.Controls.Add(Me.S25FTXT)
        Me.GroupBox13.Controls.Add(Me.M25FTXT)
        Me.GroupBox13.Controls.Add(Me.H25FTXT)
        Me.GroupBox13.Controls.Add(Me.S25ITXT)
        Me.GroupBox13.Controls.Add(Me.M25ITXT)
        Me.GroupBox13.Controls.Add(Me.H25ITXT)
        Me.GroupBox13.Controls.Add(Me.S25)
        Me.GroupBox13.Controls.Add(Me.M25)
        Me.GroupBox13.Controls.Add(Me.H25)
        Me.GroupBox13.Controls.Add(Me.Led25)
        Me.GroupBox13.ForeColor = System.Drawing.Color.White
        Me.GroupBox13.Location = New System.Drawing.Point(76, 347)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox13.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox13.TabIndex = 203
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "OUT 25        "
        '
        'S25FTXT
        '
        Me.S25FTXT.AcceptsReturn = True
        Me.S25FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S25FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S25FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S25FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S25FTXT.MaxLength = 0
        Me.S25FTXT.Name = "S25FTXT"
        Me.S25FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S25FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S25FTXT.TabIndex = 8
        Me.S25FTXT.Text = "0"
        '
        'M25FTXT
        '
        Me.M25FTXT.AcceptsReturn = True
        Me.M25FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M25FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M25FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M25FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M25FTXT.MaxLength = 0
        Me.M25FTXT.Name = "M25FTXT"
        Me.M25FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M25FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M25FTXT.TabIndex = 7
        Me.M25FTXT.Text = "0"
        '
        'H25FTXT
        '
        Me.H25FTXT.AcceptsReturn = True
        Me.H25FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H25FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H25FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H25FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H25FTXT.MaxLength = 0
        Me.H25FTXT.Name = "H25FTXT"
        Me.H25FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H25FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H25FTXT.TabIndex = 6
        Me.H25FTXT.Text = "0"
        '
        'S25ITXT
        '
        Me.S25ITXT.AcceptsReturn = True
        Me.S25ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S25ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S25ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S25ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S25ITXT.MaxLength = 0
        Me.S25ITXT.Name = "S25ITXT"
        Me.S25ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S25ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S25ITXT.TabIndex = 3
        Me.S25ITXT.Text = "0"
        '
        'M25ITXT
        '
        Me.M25ITXT.AcceptsReturn = True
        Me.M25ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M25ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M25ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M25ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M25ITXT.MaxLength = 0
        Me.M25ITXT.Name = "M25ITXT"
        Me.M25ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M25ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M25ITXT.TabIndex = 2
        Me.M25ITXT.Text = "0"
        '
        'H25ITXT
        '
        Me.H25ITXT.AcceptsReturn = True
        Me.H25ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H25ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H25ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H25ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H25ITXT.MaxLength = 0
        Me.H25ITXT.Name = "H25ITXT"
        Me.H25ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H25ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H25ITXT.TabIndex = 1
        Me.H25ITXT.Text = "0"
        '
        'S25
        '
        Me.S25.BackColor = System.Drawing.Color.Transparent
        Me.S25.Cursor = System.Windows.Forms.Cursors.Default
        Me.S25.ForeColor = System.Drawing.Color.White
        Me.S25.Location = New System.Drawing.Point(56, 16)
        Me.S25.Name = "S25"
        Me.S25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S25.Size = New System.Drawing.Size(25, 17)
        Me.S25.TabIndex = 13
        Me.S25.Text = "s:"
        '
        'M25
        '
        Me.M25.BackColor = System.Drawing.Color.Transparent
        Me.M25.Cursor = System.Windows.Forms.Cursors.Default
        Me.M25.ForeColor = System.Drawing.Color.White
        Me.M25.Location = New System.Drawing.Point(32, 16)
        Me.M25.Name = "M25"
        Me.M25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M25.Size = New System.Drawing.Size(19, 17)
        Me.M25.TabIndex = 12
        Me.M25.Text = "m:"
        '
        'H25
        '
        Me.H25.BackColor = System.Drawing.Color.Transparent
        Me.H25.Cursor = System.Windows.Forms.Cursors.Default
        Me.H25.ForeColor = System.Drawing.Color.White
        Me.H25.Location = New System.Drawing.Point(8, 16)
        Me.H25.Name = "H25"
        Me.H25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H25.Size = New System.Drawing.Size(17, 17)
        Me.H25.TabIndex = 11
        Me.H25.Text = "h:"
        '
        'Led25
        '
        Me.Led25.BackColor = System.Drawing.Color.Red
        Me.Led25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led25.Location = New System.Drawing.Point(48, 0)
        Me.Led25.Name = "Led25"
        Me.Led25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led25.Size = New System.Drawing.Size(17, 9)
        Me.Led25.TabIndex = 10
        Me.Led25.Visible = False
        '
        'Label108
        '
        Me.Label108.BackColor = System.Drawing.Color.Transparent
        Me.Label108.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label108.ForeColor = System.Drawing.Color.White
        Me.Label108.Location = New System.Drawing.Point(20, 403)
        Me.Label108.Name = "Label108"
        Me.Label108.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label108.Size = New System.Drawing.Size(49, 17)
        Me.Label108.TabIndex = 206
        Me.Label108.Text = " Final:"
        '
        'Label109
        '
        Me.Label109.BackColor = System.Drawing.Color.Transparent
        Me.Label109.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label109.ForeColor = System.Drawing.Color.White
        Me.Label109.Location = New System.Drawing.Point(20, 379)
        Me.Label109.Name = "Label109"
        Me.Label109.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label109.Size = New System.Drawing.Size(49, 17)
        Me.Label109.TabIndex = 205
        Me.Label109.Text = " Inicio:"
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox14.Controls.Add(Me.H16ITXT)
        Me.GroupBox14.Controls.Add(Me.M16ITXT)
        Me.GroupBox14.Controls.Add(Me.S16ITXT)
        Me.GroupBox14.Controls.Add(Me.H16FTXT)
        Me.GroupBox14.Controls.Add(Me.M16FTXT)
        Me.GroupBox14.Controls.Add(Me.S16FTXT)
        Me.GroupBox14.Controls.Add(Me.Led16)
        Me.GroupBox14.Controls.Add(Me.Label19)
        Me.GroupBox14.Controls.Add(Me.Label56)
        Me.GroupBox14.Controls.Add(Me.Label72)
        Me.GroupBox14.ForeColor = System.Drawing.Color.White
        Me.GroupBox14.Location = New System.Drawing.Point(873, 154)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox14.Size = New System.Drawing.Size(89, 89)
        Me.GroupBox14.TabIndex = 210
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "OUT 16         "
        '
        'H16ITXT
        '
        Me.H16ITXT.AcceptsReturn = True
        Me.H16ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H16ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H16ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H16ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H16ITXT.MaxLength = 0
        Me.H16ITXT.Name = "H16ITXT"
        Me.H16ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H16ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H16ITXT.TabIndex = 88
        Me.H16ITXT.Text = "0"
        '
        'M16ITXT
        '
        Me.M16ITXT.AcceptsReturn = True
        Me.M16ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M16ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M16ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M16ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M16ITXT.MaxLength = 0
        Me.M16ITXT.Name = "M16ITXT"
        Me.M16ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M16ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M16ITXT.TabIndex = 87
        Me.M16ITXT.Text = "0"
        '
        'S16ITXT
        '
        Me.S16ITXT.AcceptsReturn = True
        Me.S16ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S16ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S16ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S16ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S16ITXT.MaxLength = 0
        Me.S16ITXT.Name = "S16ITXT"
        Me.S16ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S16ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S16ITXT.TabIndex = 86
        Me.S16ITXT.Text = "0"
        '
        'H16FTXT
        '
        Me.H16FTXT.AcceptsReturn = True
        Me.H16FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H16FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H16FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H16FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H16FTXT.MaxLength = 0
        Me.H16FTXT.Name = "H16FTXT"
        Me.H16FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H16FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H16FTXT.TabIndex = 85
        Me.H16FTXT.Text = "0"
        '
        'M16FTXT
        '
        Me.M16FTXT.AcceptsReturn = True
        Me.M16FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M16FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M16FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M16FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M16FTXT.MaxLength = 0
        Me.M16FTXT.Name = "M16FTXT"
        Me.M16FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M16FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M16FTXT.TabIndex = 84
        Me.M16FTXT.Text = "0"
        '
        'S16FTXT
        '
        Me.S16FTXT.AcceptsReturn = True
        Me.S16FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S16FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S16FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S16FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S16FTXT.MaxLength = 0
        Me.S16FTXT.Name = "S16FTXT"
        Me.S16FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S16FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S16FTXT.TabIndex = 83
        Me.S16FTXT.Text = "0"
        '
        'Led16
        '
        Me.Led16.BackColor = System.Drawing.Color.Red
        Me.Led16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led16.Location = New System.Drawing.Point(48, 0)
        Me.Led16.Name = "Led16"
        Me.Led16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led16.Size = New System.Drawing.Size(17, 9)
        Me.Led16.TabIndex = 92
        Me.Led16.Visible = False
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(8, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(17, 17)
        Me.Label19.TabIndex = 91
        Me.Label19.Text = "h:"
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(32, 16)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(19, 17)
        Me.Label56.TabIndex = 90
        Me.Label56.Text = "m:"
        '
        'Label72
        '
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label72.ForeColor = System.Drawing.Color.White
        Me.Label72.Location = New System.Drawing.Point(56, 16)
        Me.Label72.Name = "Label72"
        Me.Label72.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label72.Size = New System.Drawing.Size(17, 17)
        Me.Label72.TabIndex = 89
        Me.Label72.Text = "s:"
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox15.Controls.Add(Me.CmdStop3)
        Me.GroupBox15.Controls.Add(Me.CmdInicio3)
        Me.GroupBox15.Controls.Add(Me.SF31TXT)
        Me.GroupBox15.Controls.Add(Me.MF31TXT)
        Me.GroupBox15.Controls.Add(Me.HF31TXT)
        Me.GroupBox15.Controls.Add(Me.Transcurrido31)
        Me.GroupBox15.Controls.Add(Me.HC31TXT)
        Me.GroupBox15.Controls.Add(Me.H31ITXT)
        Me.GroupBox15.Controls.Add(Me.M31ITXT)
        Me.GroupBox15.Controls.Add(Me.S31ITXT)
        Me.GroupBox15.Controls.Add(Me.H31FTXT)
        Me.GroupBox15.Controls.Add(Me.M31FTXT)
        Me.GroupBox15.Controls.Add(Me.S31FTXT)
        Me.GroupBox15.Controls.Add(Me.Label1)
        Me.GroupBox15.Controls.Add(Me.Label81)
        Me.GroupBox15.Controls.Add(Me.Label85)
        Me.GroupBox15.Controls.Add(Me.Led31)
        Me.GroupBox15.Controls.Add(Me.Label93)
        Me.GroupBox15.Controls.Add(Me.Label96)
        Me.GroupBox15.Controls.Add(Me.Label97)
        Me.GroupBox15.ForeColor = System.Drawing.Color.White
        Me.GroupBox15.Location = New System.Drawing.Point(537, 478)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox15.Size = New System.Drawing.Size(217, 217)
        Me.GroupBox15.TabIndex = 211
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "OUT 31         "
        '
        'CmdStop3
        '
        Me.CmdStop3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdStop3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdStop3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdStop3.Location = New System.Drawing.Point(128, 56)
        Me.CmdStop3.Name = "CmdStop3"
        Me.CmdStop3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdStop3.Size = New System.Drawing.Size(65, 25)
        Me.CmdStop3.TabIndex = 204
        Me.CmdStop3.Text = "Parar"
        Me.CmdStop3.UseVisualStyleBackColor = False
        '
        'CmdInicio3
        '
        Me.CmdInicio3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInicio3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdInicio3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdInicio3.Location = New System.Drawing.Point(128, 24)
        Me.CmdInicio3.Name = "CmdInicio3"
        Me.CmdInicio3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdInicio3.Size = New System.Drawing.Size(65, 25)
        Me.CmdInicio3.TabIndex = 203
        Me.CmdInicio3.Text = "Inicio"
        Me.CmdInicio3.UseVisualStyleBackColor = False
        '
        'SF31TXT
        '
        Me.SF31TXT.AcceptsReturn = True
        Me.SF31TXT.BackColor = System.Drawing.SystemColors.Window
        Me.SF31TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SF31TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SF31TXT.Location = New System.Drawing.Point(160, 104)
        Me.SF31TXT.MaxLength = 0
        Me.SF31TXT.Name = "SF31TXT"
        Me.SF31TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SF31TXT.Size = New System.Drawing.Size(25, 20)
        Me.SF31TXT.TabIndex = 202
        Me.SF31TXT.Text = "0"
        '
        'MF31TXT
        '
        Me.MF31TXT.AcceptsReturn = True
        Me.MF31TXT.BackColor = System.Drawing.SystemColors.Window
        Me.MF31TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MF31TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MF31TXT.Location = New System.Drawing.Point(136, 104)
        Me.MF31TXT.MaxLength = 0
        Me.MF31TXT.Name = "MF31TXT"
        Me.MF31TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MF31TXT.Size = New System.Drawing.Size(25, 20)
        Me.MF31TXT.TabIndex = 201
        Me.MF31TXT.Text = "0"
        '
        'HF31TXT
        '
        Me.HF31TXT.AcceptsReturn = True
        Me.HF31TXT.BackColor = System.Drawing.SystemColors.Window
        Me.HF31TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HF31TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HF31TXT.Location = New System.Drawing.Point(112, 104)
        Me.HF31TXT.MaxLength = 0
        Me.HF31TXT.Name = "HF31TXT"
        Me.HF31TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HF31TXT.Size = New System.Drawing.Size(25, 20)
        Me.HF31TXT.TabIndex = 200
        Me.HF31TXT.Text = "0"
        '
        'Transcurrido31
        '
        Me.Transcurrido31.AcceptsReturn = True
        Me.Transcurrido31.BackColor = System.Drawing.SystemColors.Window
        Me.Transcurrido31.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transcurrido31.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Transcurrido31.Location = New System.Drawing.Point(112, 152)
        Me.Transcurrido31.MaxLength = 0
        Me.Transcurrido31.Name = "Transcurrido31"
        Me.Transcurrido31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Transcurrido31.Size = New System.Drawing.Size(73, 20)
        Me.Transcurrido31.TabIndex = 199
        Me.Transcurrido31.Text = "0"
        '
        'HC31TXT
        '
        Me.HC31TXT.AcceptsReturn = True
        Me.HC31TXT.BackColor = System.Drawing.SystemColors.Window
        Me.HC31TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HC31TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HC31TXT.Location = New System.Drawing.Point(112, 128)
        Me.HC31TXT.MaxLength = 0
        Me.HC31TXT.Name = "HC31TXT"
        Me.HC31TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HC31TXT.Size = New System.Drawing.Size(73, 20)
        Me.HC31TXT.TabIndex = 198
        Me.HC31TXT.Text = "0"
        '
        'H31ITXT
        '
        Me.H31ITXT.AcceptsReturn = True
        Me.H31ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H31ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H31ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H31ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H31ITXT.MaxLength = 0
        Me.H31ITXT.Name = "H31ITXT"
        Me.H31ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H31ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H31ITXT.TabIndex = 186
        Me.H31ITXT.Text = "0"
        '
        'M31ITXT
        '
        Me.M31ITXT.AcceptsReturn = True
        Me.M31ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M31ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M31ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M31ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M31ITXT.MaxLength = 0
        Me.M31ITXT.Name = "M31ITXT"
        Me.M31ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M31ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M31ITXT.TabIndex = 185
        Me.M31ITXT.Text = "0"
        '
        'S31ITXT
        '
        Me.S31ITXT.AcceptsReturn = True
        Me.S31ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S31ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S31ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S31ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S31ITXT.MaxLength = 0
        Me.S31ITXT.Name = "S31ITXT"
        Me.S31ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S31ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S31ITXT.TabIndex = 184
        Me.S31ITXT.Text = "0"
        '
        'H31FTXT
        '
        Me.H31FTXT.AcceptsReturn = True
        Me.H31FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H31FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H31FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H31FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H31FTXT.MaxLength = 0
        Me.H31FTXT.Name = "H31FTXT"
        Me.H31FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H31FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H31FTXT.TabIndex = 183
        Me.H31FTXT.Text = "0"
        '
        'M31FTXT
        '
        Me.M31FTXT.AcceptsReturn = True
        Me.M31FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M31FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M31FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M31FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M31FTXT.MaxLength = 0
        Me.M31FTXT.Name = "M31FTXT"
        Me.M31FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M31FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M31FTXT.TabIndex = 182
        Me.M31FTXT.Text = "0"
        '
        'S31FTXT
        '
        Me.S31FTXT.AcceptsReturn = True
        Me.S31FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S31FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S31FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S31FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S31FTXT.MaxLength = 0
        Me.S31FTXT.Name = "S31FTXT"
        Me.S31FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S31FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S31FTXT.TabIndex = 181
        Me.S31FTXT.Text = "0"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Tiempo:"
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label81.ForeColor = System.Drawing.Color.White
        Me.Label81.Location = New System.Drawing.Point(8, 128)
        Me.Label81.Name = "Label81"
        Me.Label81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label81.Size = New System.Drawing.Size(97, 17)
        Me.Label81.TabIndex = 196
        Me.Label81.Text = "Comienzo:"
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label85.ForeColor = System.Drawing.Color.White
        Me.Label85.Location = New System.Drawing.Point(8, 104)
        Me.Label85.Name = "Label85"
        Me.Label85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label85.Size = New System.Drawing.Size(73, 17)
        Me.Label85.TabIndex = 195
        Me.Label85.Text = "Repetir cada:"
        '
        'Led31
        '
        Me.Led31.BackColor = System.Drawing.Color.Red
        Me.Led31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led31.Location = New System.Drawing.Point(48, 0)
        Me.Led31.Name = "Led31"
        Me.Led31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led31.Size = New System.Drawing.Size(17, 9)
        Me.Led31.TabIndex = 190
        Me.Led31.Visible = False
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label93.ForeColor = System.Drawing.Color.White
        Me.Label93.Location = New System.Drawing.Point(8, 16)
        Me.Label93.Name = "Label93"
        Me.Label93.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label93.Size = New System.Drawing.Size(17, 17)
        Me.Label93.TabIndex = 189
        Me.Label93.Text = "h:"
        '
        'Label96
        '
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label96.ForeColor = System.Drawing.Color.White
        Me.Label96.Location = New System.Drawing.Point(32, 16)
        Me.Label96.Name = "Label96"
        Me.Label96.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label96.Size = New System.Drawing.Size(17, 17)
        Me.Label96.TabIndex = 188
        Me.Label96.Text = "m:"
        '
        'Label97
        '
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label97.ForeColor = System.Drawing.Color.White
        Me.Label97.Location = New System.Drawing.Point(56, 16)
        Me.Label97.Name = "Label97"
        Me.Label97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label97.Size = New System.Drawing.Size(25, 17)
        Me.Label97.TabIndex = 187
        Me.Label97.Text = "s:"
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox16.Controls.Add(Me.CmdStop4)
        Me.GroupBox16.Controls.Add(Me.CmdInicio4)
        Me.GroupBox16.Controls.Add(Me.SF32TXT)
        Me.GroupBox16.Controls.Add(Me.MF32TXT)
        Me.GroupBox16.Controls.Add(Me.HF32TXT)
        Me.GroupBox16.Controls.Add(Me.Transcurrido32)
        Me.GroupBox16.Controls.Add(Me.HC32TXT)
        Me.GroupBox16.Controls.Add(Me.H32ITXT)
        Me.GroupBox16.Controls.Add(Me.M32ITXT)
        Me.GroupBox16.Controls.Add(Me.S32ITXT)
        Me.GroupBox16.Controls.Add(Me.H32FTXT)
        Me.GroupBox16.Controls.Add(Me.M32FTXT)
        Me.GroupBox16.Controls.Add(Me.S32FTXT)
        Me.GroupBox16.Controls.Add(Me.Label86)
        Me.GroupBox16.Controls.Add(Me.Label98)
        Me.GroupBox16.Controls.Add(Me.Label99)
        Me.GroupBox16.Controls.Add(Me.Led32)
        Me.GroupBox16.Controls.Add(Me.Label101)
        Me.GroupBox16.Controls.Add(Me.Label102)
        Me.GroupBox16.Controls.Add(Me.Label103)
        Me.GroupBox16.ForeColor = System.Drawing.Color.White
        Me.GroupBox16.Location = New System.Drawing.Point(770, 478)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox16.Size = New System.Drawing.Size(216, 217)
        Me.GroupBox16.TabIndex = 212
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "OUT 32        "
        '
        'CmdStop4
        '
        Me.CmdStop4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdStop4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdStop4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdStop4.Location = New System.Drawing.Point(128, 56)
        Me.CmdStop4.Name = "CmdStop4"
        Me.CmdStop4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdStop4.Size = New System.Drawing.Size(65, 25)
        Me.CmdStop4.TabIndex = 204
        Me.CmdStop4.Text = "Parar"
        Me.CmdStop4.UseVisualStyleBackColor = False
        '
        'CmdInicio4
        '
        Me.CmdInicio4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdInicio4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdInicio4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdInicio4.Location = New System.Drawing.Point(128, 24)
        Me.CmdInicio4.Name = "CmdInicio4"
        Me.CmdInicio4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdInicio4.Size = New System.Drawing.Size(65, 25)
        Me.CmdInicio4.TabIndex = 203
        Me.CmdInicio4.Text = "Inicio"
        Me.CmdInicio4.UseVisualStyleBackColor = False
        '
        'SF32TXT
        '
        Me.SF32TXT.AcceptsReturn = True
        Me.SF32TXT.BackColor = System.Drawing.SystemColors.Window
        Me.SF32TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SF32TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SF32TXT.Location = New System.Drawing.Point(160, 104)
        Me.SF32TXT.MaxLength = 0
        Me.SF32TXT.Name = "SF32TXT"
        Me.SF32TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SF32TXT.Size = New System.Drawing.Size(25, 20)
        Me.SF32TXT.TabIndex = 202
        Me.SF32TXT.Text = "0"
        '
        'MF32TXT
        '
        Me.MF32TXT.AcceptsReturn = True
        Me.MF32TXT.BackColor = System.Drawing.SystemColors.Window
        Me.MF32TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MF32TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MF32TXT.Location = New System.Drawing.Point(136, 104)
        Me.MF32TXT.MaxLength = 0
        Me.MF32TXT.Name = "MF32TXT"
        Me.MF32TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MF32TXT.Size = New System.Drawing.Size(25, 20)
        Me.MF32TXT.TabIndex = 201
        Me.MF32TXT.Text = "0"
        '
        'HF32TXT
        '
        Me.HF32TXT.AcceptsReturn = True
        Me.HF32TXT.BackColor = System.Drawing.SystemColors.Window
        Me.HF32TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HF32TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HF32TXT.Location = New System.Drawing.Point(112, 104)
        Me.HF32TXT.MaxLength = 0
        Me.HF32TXT.Name = "HF32TXT"
        Me.HF32TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HF32TXT.Size = New System.Drawing.Size(25, 20)
        Me.HF32TXT.TabIndex = 200
        Me.HF32TXT.Text = "0"
        '
        'Transcurrido32
        '
        Me.Transcurrido32.AcceptsReturn = True
        Me.Transcurrido32.BackColor = System.Drawing.SystemColors.Window
        Me.Transcurrido32.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transcurrido32.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Transcurrido32.Location = New System.Drawing.Point(112, 152)
        Me.Transcurrido32.MaxLength = 0
        Me.Transcurrido32.Name = "Transcurrido32"
        Me.Transcurrido32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Transcurrido32.Size = New System.Drawing.Size(73, 20)
        Me.Transcurrido32.TabIndex = 199
        Me.Transcurrido32.Text = "0"
        '
        'HC32TXT
        '
        Me.HC32TXT.AcceptsReturn = True
        Me.HC32TXT.BackColor = System.Drawing.SystemColors.Window
        Me.HC32TXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HC32TXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HC32TXT.Location = New System.Drawing.Point(112, 128)
        Me.HC32TXT.MaxLength = 0
        Me.HC32TXT.Name = "HC32TXT"
        Me.HC32TXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HC32TXT.Size = New System.Drawing.Size(73, 20)
        Me.HC32TXT.TabIndex = 198
        Me.HC32TXT.Text = "0"
        '
        'H32ITXT
        '
        Me.H32ITXT.AcceptsReturn = True
        Me.H32ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.H32ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H32ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H32ITXT.Location = New System.Drawing.Point(8, 32)
        Me.H32ITXT.MaxLength = 0
        Me.H32ITXT.Name = "H32ITXT"
        Me.H32ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H32ITXT.Size = New System.Drawing.Size(25, 20)
        Me.H32ITXT.TabIndex = 186
        Me.H32ITXT.Text = "0"
        '
        'M32ITXT
        '
        Me.M32ITXT.AcceptsReturn = True
        Me.M32ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.M32ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M32ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M32ITXT.Location = New System.Drawing.Point(32, 32)
        Me.M32ITXT.MaxLength = 0
        Me.M32ITXT.Name = "M32ITXT"
        Me.M32ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M32ITXT.Size = New System.Drawing.Size(25, 20)
        Me.M32ITXT.TabIndex = 185
        Me.M32ITXT.Text = "0"
        '
        'S32ITXT
        '
        Me.S32ITXT.AcceptsReturn = True
        Me.S32ITXT.BackColor = System.Drawing.SystemColors.Window
        Me.S32ITXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S32ITXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S32ITXT.Location = New System.Drawing.Point(56, 32)
        Me.S32ITXT.MaxLength = 0
        Me.S32ITXT.Name = "S32ITXT"
        Me.S32ITXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S32ITXT.Size = New System.Drawing.Size(25, 20)
        Me.S32ITXT.TabIndex = 184
        Me.S32ITXT.Text = "0"
        '
        'H32FTXT
        '
        Me.H32FTXT.AcceptsReturn = True
        Me.H32FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.H32FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.H32FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.H32FTXT.Location = New System.Drawing.Point(8, 56)
        Me.H32FTXT.MaxLength = 0
        Me.H32FTXT.Name = "H32FTXT"
        Me.H32FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.H32FTXT.Size = New System.Drawing.Size(25, 20)
        Me.H32FTXT.TabIndex = 183
        Me.H32FTXT.Text = "0"
        '
        'M32FTXT
        '
        Me.M32FTXT.AcceptsReturn = True
        Me.M32FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.M32FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.M32FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.M32FTXT.Location = New System.Drawing.Point(32, 56)
        Me.M32FTXT.MaxLength = 0
        Me.M32FTXT.Name = "M32FTXT"
        Me.M32FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.M32FTXT.Size = New System.Drawing.Size(25, 20)
        Me.M32FTXT.TabIndex = 182
        Me.M32FTXT.Text = "0"
        '
        'S32FTXT
        '
        Me.S32FTXT.AcceptsReturn = True
        Me.S32FTXT.BackColor = System.Drawing.SystemColors.Window
        Me.S32FTXT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S32FTXT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.S32FTXT.Location = New System.Drawing.Point(56, 56)
        Me.S32FTXT.MaxLength = 0
        Me.S32FTXT.Name = "S32FTXT"
        Me.S32FTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.S32FTXT.Size = New System.Drawing.Size(25, 20)
        Me.S32FTXT.TabIndex = 181
        Me.S32FTXT.Text = "0"
        '
        'Label86
        '
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label86.ForeColor = System.Drawing.Color.White
        Me.Label86.Location = New System.Drawing.Point(8, 152)
        Me.Label86.Name = "Label86"
        Me.Label86.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label86.Size = New System.Drawing.Size(107, 17)
        Me.Label86.TabIndex = 197
        Me.Label86.Text = "Tiempo:"
        '
        'Label98
        '
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label98.ForeColor = System.Drawing.Color.White
        Me.Label98.Location = New System.Drawing.Point(8, 128)
        Me.Label98.Name = "Label98"
        Me.Label98.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label98.Size = New System.Drawing.Size(97, 17)
        Me.Label98.TabIndex = 196
        Me.Label98.Text = "Comienzo:"
        '
        'Label99
        '
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label99.ForeColor = System.Drawing.Color.White
        Me.Label99.Location = New System.Drawing.Point(8, 104)
        Me.Label99.Name = "Label99"
        Me.Label99.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label99.Size = New System.Drawing.Size(73, 17)
        Me.Label99.TabIndex = 195
        Me.Label99.Text = "Repetir cada:"
        '
        'Led32
        '
        Me.Led32.BackColor = System.Drawing.Color.Red
        Me.Led32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Led32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Led32.Location = New System.Drawing.Point(48, 0)
        Me.Led32.Name = "Led32"
        Me.Led32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Led32.Size = New System.Drawing.Size(17, 9)
        Me.Led32.TabIndex = 190
        Me.Led32.Visible = False
        '
        'Label101
        '
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label101.ForeColor = System.Drawing.Color.White
        Me.Label101.Location = New System.Drawing.Point(8, 16)
        Me.Label101.Name = "Label101"
        Me.Label101.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label101.Size = New System.Drawing.Size(17, 17)
        Me.Label101.TabIndex = 189
        Me.Label101.Text = "h:"
        '
        'Label102
        '
        Me.Label102.BackColor = System.Drawing.Color.Transparent
        Me.Label102.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label102.ForeColor = System.Drawing.Color.White
        Me.Label102.Location = New System.Drawing.Point(32, 16)
        Me.Label102.Name = "Label102"
        Me.Label102.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label102.Size = New System.Drawing.Size(17, 17)
        Me.Label102.TabIndex = 188
        Me.Label102.Text = "m:"
        '
        'Label103
        '
        Me.Label103.BackColor = System.Drawing.Color.Transparent
        Me.Label103.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label103.ForeColor = System.Drawing.Color.White
        Me.Label103.Location = New System.Drawing.Point(56, 16)
        Me.Label103.Name = "Label103"
        Me.Label103.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label103.Size = New System.Drawing.Size(25, 17)
        Me.Label103.TabIndex = 187
        Me.Label103.Text = "s:"
        '
        'MediaPlayer1
        '
        Me.MediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.OcxState = CType(resources.GetObject("MediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer1.Size = New System.Drawing.Size(286, 225)
        Me.MediaPlayer1.TabIndex = 213
        Me.MediaPlayer1.Visible = False
        '
        'temporizador_belen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1018, 748)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.Controls.Add(Me.GroupBox16)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.Label108)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label94)
        Me.Controls.Add(Me.Label95)
        Me.Controls.Add(Me.Frame16)
        Me.Controls.Add(Me.Frame15)
        Me.Controls.Add(Me.Frame14)
        Me.Controls.Add(Me.Frame13)
        Me.Controls.Add(Me.Frame12)
        Me.Controls.Add(Me.Frame11)
        Me.Controls.Add(Me.Frame10)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.CmdStop)
        Me.Controls.Add(Me.SGITXT)
        Me.Controls.Add(Me.MGITXT)
        Me.Controls.Add(Me.HGITXT)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me._Frame2_0)
        Me.Controls.Add(Me.HActualTxt)
        Me.Controls.Add(Me.CmdInicio)
        Me.Controls.Add(Me.HCtxt)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(162, 140)
        Me.MaximizeBox = False
        Me.Name = "temporizador_belen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Temporizador Belen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame16.ResumeLayout(False)
        Me.Frame16.PerformLayout()
        Me.Frame15.ResumeLayout(False)
        Me.Frame15.PerformLayout()
        Me.Frame14.ResumeLayout(False)
        Me.Frame14.PerformLayout()
        Me.Frame13.ResumeLayout(False)
        Me.Frame13.PerformLayout()
        Me.Frame12.ResumeLayout(False)
        Me.Frame12.PerformLayout()
        Me.Frame11.ResumeLayout(False)
        Me.Frame11.PerformLayout()
        Me.Frame10.ResumeLayout(False)
        Me.Frame10.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame9.PerformLayout()
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me._Frame2_0.ResumeLayout(False)
        Me._Frame2_0.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.Frame2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents H24ITXT As System.Windows.Forms.TextBox
    Public WithEvents M24ITXT As System.Windows.Forms.TextBox
    Public WithEvents S24ITXT As System.Windows.Forms.TextBox
    Public WithEvents H24FTXT As System.Windows.Forms.TextBox
    Public WithEvents M24FTXT As System.Windows.Forms.TextBox
    Public WithEvents S24FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led24 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents H23ITXT As System.Windows.Forms.TextBox
    Public WithEvents M23ITXT As System.Windows.Forms.TextBox
    Public WithEvents S23ITXT As System.Windows.Forms.TextBox
    Public WithEvents H23FTXT As System.Windows.Forms.TextBox
    Public WithEvents M23FTXT As System.Windows.Forms.TextBox
    Public WithEvents S23FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led23 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents S22FTXT As System.Windows.Forms.TextBox
    Public WithEvents M22FTXT As System.Windows.Forms.TextBox
    Public WithEvents H22FTXT As System.Windows.Forms.TextBox
    Public WithEvents S22ITXT As System.Windows.Forms.TextBox
    Public WithEvents M22ITXT As System.Windows.Forms.TextBox
    Public WithEvents H22ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents Label52 As System.Windows.Forms.Label
    Public WithEvents Led22 As System.Windows.Forms.Label
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents S21FTXT As System.Windows.Forms.TextBox
    Public WithEvents M21FTXT As System.Windows.Forms.TextBox
    Public WithEvents H21FTXT As System.Windows.Forms.TextBox
    Public WithEvents S21ITXT As System.Windows.Forms.TextBox
    Public WithEvents M21ITXT As System.Windows.Forms.TextBox
    Public WithEvents H21ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label60 As System.Windows.Forms.Label
    Public WithEvents Label64 As System.Windows.Forms.Label
    Public WithEvents Label68 As System.Windows.Forms.Label
    Public WithEvents Led21 As System.Windows.Forms.Label
    Public WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Public WithEvents S20FTXT As System.Windows.Forms.TextBox
    Public WithEvents M20FTXT As System.Windows.Forms.TextBox
    Public WithEvents H20FTXT As System.Windows.Forms.TextBox
    Public WithEvents S20ITXT As System.Windows.Forms.TextBox
    Public WithEvents M20ITXT As System.Windows.Forms.TextBox
    Public WithEvents H20ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label75 As System.Windows.Forms.Label
    Public WithEvents Label79 As System.Windows.Forms.Label
    Public WithEvents Label80 As System.Windows.Forms.Label
    Public WithEvents Led20 As System.Windows.Forms.Label
    Public WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Public WithEvents S19FTXT As System.Windows.Forms.TextBox
    Public WithEvents M19FTXT As System.Windows.Forms.TextBox
    Public WithEvents H19FTXT As System.Windows.Forms.TextBox
    Public WithEvents S19ITXT As System.Windows.Forms.TextBox
    Public WithEvents M19ITXT As System.Windows.Forms.TextBox
    Public WithEvents H19ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label82 As System.Windows.Forms.Label
    Public WithEvents Label83 As System.Windows.Forms.Label
    Public WithEvents Label84 As System.Windows.Forms.Label
    Public WithEvents Led19 As System.Windows.Forms.Label
    Public WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Public WithEvents H18ITXT As System.Windows.Forms.TextBox
    Public WithEvents M18ITXT As System.Windows.Forms.TextBox
    Public WithEvents S18ITXT As System.Windows.Forms.TextBox
    Public WithEvents H18FTXT As System.Windows.Forms.TextBox
    Public WithEvents M18FTXT As System.Windows.Forms.TextBox
    Public WithEvents S18FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led18 As System.Windows.Forms.Label
    Public WithEvents Label87 As System.Windows.Forms.Label
    Public WithEvents Label88 As System.Windows.Forms.Label
    Public WithEvents Label89 As System.Windows.Forms.Label
    Public WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Public WithEvents S17FTXT As System.Windows.Forms.TextBox
    Public WithEvents M17FTXT As System.Windows.Forms.TextBox
    Public WithEvents H17FTXT As System.Windows.Forms.TextBox
    Public WithEvents S17ITXT As System.Windows.Forms.TextBox
    Public WithEvents M17ITXT As System.Windows.Forms.TextBox
    Public WithEvents H17ITXT As System.Windows.Forms.TextBox
    Public WithEvents Label90 As System.Windows.Forms.Label
    Public WithEvents Label91 As System.Windows.Forms.Label
    Public WithEvents Label92 As System.Windows.Forms.Label
    Public WithEvents Led17 As System.Windows.Forms.Label
    Public WithEvents Label94 As System.Windows.Forms.Label
    Public WithEvents Label95 As System.Windows.Forms.Label
    Public WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Public WithEvents S29FTXT As System.Windows.Forms.TextBox
    Public WithEvents M29FTXT As System.Windows.Forms.TextBox
    Public WithEvents H29FTXT As System.Windows.Forms.TextBox
    Public WithEvents S29ITXT As System.Windows.Forms.TextBox
    Public WithEvents M29ITXT As System.Windows.Forms.TextBox
    Public WithEvents H29ITXT As System.Windows.Forms.TextBox
    Public WithEvents S29 As System.Windows.Forms.Label
    Public WithEvents M29 As System.Windows.Forms.Label
    Public WithEvents H29 As System.Windows.Forms.Label
    Public WithEvents Led29 As System.Windows.Forms.Label
    Public WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Public WithEvents S28FTXT As System.Windows.Forms.TextBox
    Public WithEvents M28FTXT As System.Windows.Forms.TextBox
    Public WithEvents H28FTXT As System.Windows.Forms.TextBox
    Public WithEvents S28ITXT As System.Windows.Forms.TextBox
    Public WithEvents M28ITXT As System.Windows.Forms.TextBox
    Public WithEvents H28ITXT As System.Windows.Forms.TextBox
    Public WithEvents S28 As System.Windows.Forms.Label
    Public WithEvents M28 As System.Windows.Forms.Label
    Public WithEvents H28 As System.Windows.Forms.Label
    Public WithEvents Led28 As System.Windows.Forms.Label
    Public WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Public WithEvents S27FTXT As System.Windows.Forms.TextBox
    Public WithEvents M27FTXT As System.Windows.Forms.TextBox
    Public WithEvents H27FTXT As System.Windows.Forms.TextBox
    Public WithEvents S27ITXT As System.Windows.Forms.TextBox
    Public WithEvents M27ITXT As System.Windows.Forms.TextBox
    Public WithEvents H27ITXT As System.Windows.Forms.TextBox
    Public WithEvents S27 As System.Windows.Forms.Label
    Public WithEvents M27 As System.Windows.Forms.Label
    Public WithEvents H27 As System.Windows.Forms.Label
    Public WithEvents Led27 As System.Windows.Forms.Label
    Public WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Public WithEvents H26ITXT As System.Windows.Forms.TextBox
    Public WithEvents M26ITXT As System.Windows.Forms.TextBox
    Public WithEvents S26ITXT As System.Windows.Forms.TextBox
    Public WithEvents H26FTXT As System.Windows.Forms.TextBox
    Public WithEvents M26FTXT As System.Windows.Forms.TextBox
    Public WithEvents S26FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led26 As System.Windows.Forms.Label
    Public WithEvents H26 As System.Windows.Forms.Label
    Public WithEvents M26 As System.Windows.Forms.Label
    Public WithEvents S26 As System.Windows.Forms.Label
    Public WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Public WithEvents S25FTXT As System.Windows.Forms.TextBox
    Public WithEvents M25FTXT As System.Windows.Forms.TextBox
    Public WithEvents H25FTXT As System.Windows.Forms.TextBox
    Public WithEvents S25ITXT As System.Windows.Forms.TextBox
    Public WithEvents M25ITXT As System.Windows.Forms.TextBox
    Public WithEvents H25ITXT As System.Windows.Forms.TextBox
    Public WithEvents S25 As System.Windows.Forms.Label
    Public WithEvents M25 As System.Windows.Forms.Label
    Public WithEvents H25 As System.Windows.Forms.Label
    Public WithEvents Led25 As System.Windows.Forms.Label
    Public WithEvents Label108 As System.Windows.Forms.Label
    Public WithEvents Label109 As System.Windows.Forms.Label
    Public WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Public WithEvents H16ITXT As System.Windows.Forms.TextBox
    Public WithEvents M16ITXT As System.Windows.Forms.TextBox
    Public WithEvents S16ITXT As System.Windows.Forms.TextBox
    Public WithEvents H16FTXT As System.Windows.Forms.TextBox
    Public WithEvents M16FTXT As System.Windows.Forms.TextBox
    Public WithEvents S16FTXT As System.Windows.Forms.TextBox
    Public WithEvents Led16 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label56 As System.Windows.Forms.Label
    Public WithEvents Label72 As System.Windows.Forms.Label
    Public WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Public WithEvents CmdStop3 As System.Windows.Forms.Button
    Public WithEvents CmdInicio3 As System.Windows.Forms.Button
    Public WithEvents SF31TXT As System.Windows.Forms.TextBox
    Public WithEvents MF31TXT As System.Windows.Forms.TextBox
    Public WithEvents HF31TXT As System.Windows.Forms.TextBox
    Public WithEvents Transcurrido31 As System.Windows.Forms.TextBox
    Public WithEvents HC31TXT As System.Windows.Forms.TextBox
    Public WithEvents H31ITXT As System.Windows.Forms.TextBox
    Public WithEvents M31ITXT As System.Windows.Forms.TextBox
    Public WithEvents S31ITXT As System.Windows.Forms.TextBox
    Public WithEvents H31FTXT As System.Windows.Forms.TextBox
    Public WithEvents M31FTXT As System.Windows.Forms.TextBox
    Public WithEvents S31FTXT As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label81 As System.Windows.Forms.Label
    Public WithEvents Label85 As System.Windows.Forms.Label
    Public WithEvents Led31 As System.Windows.Forms.Label
    Public WithEvents Label93 As System.Windows.Forms.Label
    Public WithEvents Label96 As System.Windows.Forms.Label
    Public WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Public WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Public WithEvents CmdStop4 As System.Windows.Forms.Button
    Public WithEvents CmdInicio4 As System.Windows.Forms.Button
    Public WithEvents SF32TXT As System.Windows.Forms.TextBox
    Public WithEvents MF32TXT As System.Windows.Forms.TextBox
    Public WithEvents HF32TXT As System.Windows.Forms.TextBox
    Public WithEvents Transcurrido32 As System.Windows.Forms.TextBox
    Public WithEvents HC32TXT As System.Windows.Forms.TextBox
    Public WithEvents H32ITXT As System.Windows.Forms.TextBox
    Public WithEvents M32ITXT As System.Windows.Forms.TextBox
    Public WithEvents S32ITXT As System.Windows.Forms.TextBox
    Public WithEvents H32FTXT As System.Windows.Forms.TextBox
    Public WithEvents M32FTXT As System.Windows.Forms.TextBox
    Public WithEvents S32FTXT As System.Windows.Forms.TextBox
    Public WithEvents Label86 As System.Windows.Forms.Label
    Public WithEvents Label98 As System.Windows.Forms.Label
    Public WithEvents Label99 As System.Windows.Forms.Label
    Public WithEvents Led32 As System.Windows.Forms.Label
    Public WithEvents Label101 As System.Windows.Forms.Label
    Public WithEvents Label102 As System.Windows.Forms.Label
    Public WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents MediaPlayer1 As AxMediaPlayer.AxMediaPlayer
#End Region
End Class