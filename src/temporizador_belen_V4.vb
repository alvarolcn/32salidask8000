Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports System.IO.TextReader
Friend Class temporizador_belen
    Inherits System.Windows.Forms.Form
    Dim H1I, M1I As Object
    Dim S1I As Short
    Dim H1F, M1F As Object
    Dim S1F As Short
    Dim Inicio1 As Object
    Dim Final1 As Integer

    Dim H2I, M2I As Object
    Dim S2I As Short
    Dim H2F, M2F As Object
    Dim S2F As Short
    Dim Inicio2 As Object
    Dim Final2 As Integer

    Dim H3I, M3I As Object
    Dim S3I As Short
    Dim H3F, M3F As Object
    Dim S3F As Short
    Dim Inicio3 As Object
    Dim Final3 As Integer

    Dim H4I, M4I As Object
    Dim S4I As Short
    Dim H4F, M4F As Object
    Dim S4F As Short
    Dim Inicio4 As Object
    Dim Final4 As Integer

    Dim H5I, M5I As Object
    Dim S5I As Short
    Dim H5F, M5F As Object
    Dim S5F As Short
    Dim Inicio5 As Object
    Dim Final5 As Integer

    Dim H6I, M6I As Object
    Dim S6I As Short
    Dim H6F, M6F As Object
    Dim S6F As Short
    Dim Inicio6 As Object
    Dim Final6 As Integer

    Dim H7I, M7I As Object
    Dim S7I As Short
    Dim H7F, M7F As Object
    Dim S7F As Short
    Dim Inicio7 As Object
    Dim Final7 As Integer

    Dim H8I, M8I As Object
    Dim S8I As Short
    Dim H8F, M8F As Object
    Dim S8F As Short
    Dim Inicio8 As Object
    Dim Final8 As Integer

    Dim H9I, M9I As Object
    Dim S9I As Short
    Dim H9F, M9F As Object
    Dim S9F As Short
    Dim Inicio9 As Object
    Dim Final9 As Integer

    Dim H10I, M10I As Object
    Dim S10I As Short
    Dim H10F, M10F As Object
    Dim S10F As Short
    Dim Inicio10 As Object
    Dim Final10 As Integer

    Dim H11I, M11I As Object
    Dim S11I As Short
    Dim H11F, M11F As Object
    Dim S11F As Short
    Dim Inicio11 As Object
    Dim Final11 As Integer

    Dim H12I, M12I As Object
    Dim S12I As Short
    Dim H12F, M12F As Object
    Dim S12F As Short
    Dim Inicio12 As Object
    Dim Final12 As Integer

    Dim H13I, M13I As Object
    Dim S13I As Short
    Dim H13F, M13F As Object
    Dim S13F As Short
    Dim Inicio13 As Object
    Dim Final13 As Integer

    Dim H14I, M14I As Object
    Dim S14I As Short
    Dim H14F, M14F As Object
    Dim S14F As Short
    Dim Inicio14 As Object
    Dim Final14 As Integer

    Dim H15I, M15I As Object
    Dim S15I As Short
    Dim H15F, M15F As Object
    Dim S15F As Short
    Dim Inicio15 As Object
    Dim Final15 As Integer

    Dim H16I, M16I As Object
    Dim S16I As Short
    Dim H16F, M16F As Object
    Dim S16F As Short
    Dim Inicio16 As Object
    Dim Final16 As Integer

    Dim H17I, M17I As Object
    Dim S17I As Short
    Dim H17F, M17F As Object
    Dim S17F As Short
    Dim Inicio17 As Object
    Dim Final17 As Integer

    Dim H18I, M18I As Object
    Dim S18I As Short
    Dim H18F, M18F As Object
    Dim S18F As Short
    Dim Inicio18 As Object
    Dim Final18 As Integer

    Dim H19I, M19I As Object
    Dim S19I As Short
    Dim H19F, M19F As Object
    Dim S19F As Short
    Dim Inicio19 As Object
    Dim Final19 As Integer

    Dim H20I, M20I As Object
    Dim S20I As Short
    Dim H20F, M20F As Object
    Dim S20F As Short
    Dim Inicio20 As Object
    Dim Final20 As Integer

    Dim H21I, M21I As Object
    Dim S21I As Short
    Dim H21F, M21F As Object
    Dim S21F As Short
    Dim Inicio21 As Object
    Dim Final21 As Integer

    Dim H22I, M22I As Object
    Dim S22I As Short
    Dim H22F, M22F As Object
    Dim S22F As Short
    Dim Inicio22 As Object
    Dim Final22 As Integer

    Dim H23I, M23I As Object
    Dim S23I As Short
    Dim H23F, M23F As Object
    Dim S23F As Short
    Dim Inicio23 As Object
    Dim Final23 As Integer

    Dim H24I, M24I As Object
    Dim S24I As Short
    Dim H24F, M24F As Object
    Dim S24F As Short
    Dim Inicio24 As Object
    Dim Final24 As Integer

    Dim H25I, M25I As Object
    Dim S25I As Short
    Dim H25F, M25F As Object
    Dim S25F As Short
    Dim Inicio25 As Object
    Dim Final25 As Integer

    Dim H26I, M26I As Object
    Dim S26I As Short
    Dim H26F, M26F As Object
    Dim S26F As Short
    Dim Inicio26 As Object
    Dim Final26 As Integer

    Dim H27I, M27I As Object
    Dim S27I As Short
    Dim H27F, M27F As Object
    Dim S27F As Short
    Dim Inicio27 As Object
    Dim Final27 As Integer

    Dim H28I, M28I As Object
    Dim S28I As Short
    Dim H28F, M28F As Object
    Dim S28F As Short
    Dim Inicio28 As Object
    Dim Final28 As Integer

    Dim H29I, M29I As Object
    Dim S29I As Short
    Dim H29F, M29F As Object
    Dim S29F As Short
    Dim Inicio29 As Object
    Dim Final29 As Integer


    Dim HC, MC As Object
    Dim SC As Short
    Dim H, M As Object
    Dim S As Short
    Dim Final As Object
    Dim HFinal, MFinal As Object
    Dim SFinal As Short





    Dim HC30, MC30 As Object
    Dim SC30 As Short
    Dim FinalCanal30 As Integer
    Dim HFinal30, MFinal30 As Object
    Dim SFinal30 As Short
    Dim H30, M30 As Object
    Dim S30 As Short
    Dim H30I, M30I As Object
    Dim S30I As Short
    Dim H30F, M30F As Object
    Dim S30F As Short
    Dim Inicio30 As Object
    Dim Final30 As Integer


    Dim HC31, MC31 As Object
    Dim SC31 As Short
    Dim FinalCanal31 As Integer
    Dim HFinal31, MFinal31 As Object
    Dim SFinal31 As Short
    Dim H31, M31 As Object
    Dim S31 As Short
    Dim H31I, M31I As Object
    Dim S31I As Short
    Dim H31F, M31F As Object
    Dim S31F As Short
    Dim Inicio31 As Object
    Dim Final31 As Integer


    Dim HC32, MC32 As Object
    Dim SC32 As Short
    Dim FinalCanal32 As Integer
    Dim HFinal32, MFinal32 As Object
    Dim SFinal32 As Short
    Dim H32, M32 As Object
    Dim S32 As Short
    Dim H32I, M32I As Object
    Dim S32I As Short
    Dim H32F, M32F As Object
    Dim S32F As Short
    Dim Inicio32 As Object
    Dim Final32 As Integer


    Dim HangelI, MangelI As Object
    Dim SangelI As Short
    Dim HangelBAJADA, MangelBAJADA As Object
    Dim SangelBAJADA As Short
    Dim HangelPAUSA, MangelPAUSA As Object
    Dim SangelPAUSA As Short
    Dim HangelSUBIDA, MangelSUBIDA As Object
    Dim SangelSUBIDA As Short
    Dim INICIOAngel As Integer
    Dim BAJADAAngel As Integer
    Dim PAUSAAngel As Integer
    Dim SUBIDAAngel As Integer

    Dim res1 As Integer = 0
    Dim res2 As Integer = 0
    Dim res3 As Integer = 0
    Dim res4 As Integer = 0


    Dim Ret As Long
    'Declaracion de la funcion para la pantalla completa del video
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long


    'HC MC SC hora, minutos y segundos de comienzo de todo el proceso
    Private Sub CmdInicio_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdInicio.Click

        

        HFinal = CShort(HGITXT.Text)
        MFinal = CShort(MGITXT.Text)
        SFinal = CShort(SGITXT.Text)


        'OUT1
        H1I = CShort(H1ITXT.Text)
        M1I = CShort(M1ITXT.Text)
        S1I = CShort(S1ITXT.Text)

        H1F = CShort(H1FTXT.Text)
        M1F = CShort(M1FTXT.Text)
        S1F = CShort(S1FTXT.Text)

        'OUT2
        H2I = CShort(H2ITXT.Text)
        M2I = CShort(M2ITXT.Text)
        S2I = CShort(S2ITXT.Text)

        H2F = CShort(H2FTXT.Text)
        M2F = CShort(M2FTXT.Text)
        S2F = CShort(S2FTXT.Text)

        'OUT3
        H3I = CShort(H3ITXT.Text)
        M3I = CShort(M3ITXT.Text)
        S3I = CShort(S3ITXT.Text)

        H3F = CShort(H3FTXT.Text)
        M3F = CShort(M3FTXT.Text)
        S3F = CShort(S3FTXT.Text)

        'OUT4
        H4I = CShort(H4ITXT.Text)
        M4I = CShort(M4ITXT.Text)
        S4I = CShort(S4ITXT.Text)

        H4F = CShort(H4FTXT.Text)
        M4F = CShort(M4FTXT.Text)
        S4F = CShort(S4FTXT.Text)

        'OUT5
        H5I = CShort(H5ITXT.Text)
        M5I = CShort(M5ITXT.Text)
        S5I = CShort(S5ITXT.Text)

        H5F = CShort(H5FTXT.Text)
        M5F = CShort(M5FTXT.Text)
        S5F = CShort(S5FTXT.Text)

        'OUT6
        H6I = CShort(H6ITXT.Text)
        M6I = CShort(M6ITXT.Text)
        S6I = CShort(S6ITXT.Text)

        H6F = CShort(H6FTXT.Text)
        M6F = CShort(M6FTXT.Text)
        S6F = CShort(S6FTXT.Text)

        'OUT7
        H7I = CShort(H7ITXT.Text)
        M7I = CShort(M7ITXT.Text)
        S7I = CShort(S7ITXT.Text)

        H7F = CShort(H7FTXT.Text)
        M7F = CShort(M7FTXT.Text)
        S7F = CShort(S7FTXT.Text)

        'OUT8
        H8I = CShort(H8ITXT.Text)
        M8I = CShort(M8ITXT.Text)
        S8I = CShort(S8ITXT.Text)

        H8F = CShort(H8FTXT.Text)
        M8F = CShort(M8FTXT.Text)
        S8F = CShort(S8FTXT.Text)

        'OUT9
        H9I = CShort(H9ITXT.Text)
        M9I = CShort(M9ITXT.Text)
        S9I = CShort(S9ITXT.Text)

        H9F = CShort(H9FTXT.Text)
        M9F = CShort(M9FTXT.Text)
        S9F = CShort(S9FTXT.Text)

        'OUT10
        H10I = CShort(H10ITXT.Text)
        M10I = CShort(M10ITXT.Text)
        S10I = CShort(S10ITXT.Text)

        H10F = CShort(H10FTXT.Text)
        M10F = CShort(M10FTXT.Text)
        S10F = CShort(S10FTXT.Text)

        'OUT11
        H11I = CShort(H11ITXT.Text)
        M11I = CShort(M11ITXT.Text)
        S11I = CShort(S11ITXT.Text)

        H11F = CShort(H11FTXT.Text)
        M11F = CShort(M11FTXT.Text)
        S11F = CShort(S11FTXT.Text)

        'OUT12
        H12I = CShort(H12ITXT.Text)
        M12I = CShort(M12ITXT.Text)
        S12I = CShort(S12ITXT.Text)

        H12F = CShort(H12FTXT.Text)
        M12F = CShort(M12FTXT.Text)
        S12F = CShort(S12FTXT.Text)

        'OUT13
        H13I = CShort(H13ITXT.Text)
        M13I = CShort(M13ITXT.Text)
        S13I = CShort(S13ITXT.Text)

        H13F = CShort(H13FTXT.Text)
        M13F = CShort(M13FTXT.Text)
        S13F = CShort(S13FTXT.Text)

        'OUT14
        H14I = CShort(H14ITXT.Text)
        M14I = CShort(M14ITXT.Text)
        S14I = CShort(S14ITXT.Text)

        H14F = CShort(H14FTXT.Text)
        M14F = CShort(M14FTXT.Text)
        S14F = CShort(S14FTXT.Text)

        'OUT15
        H15I = CShort(H15ITXT.Text)
        M15I = CShort(M15ITXT.Text)
        S15I = CShort(S15ITXT.Text)

        H15F = CShort(H15FTXT.Text)
        M15F = CShort(M15FTXT.Text)
        S15F = CShort(S15FTXT.Text)

        'OUT16
        H16I = CShort(H16ITXT.Text)
        M16I = CShort(M16ITXT.Text)
        S16I = CShort(S16ITXT.Text)

        H16F = CShort(H16FTXT.Text)
        M16F = CShort(M16FTXT.Text)
        S16F = CShort(S16FTXT.Text)

        'OUT17
        H17I = CShort(H17ITXT.Text)
        M17I = CShort(M17ITXT.Text)
        S17I = CShort(S17ITXT.Text)

        H17F = CShort(H17FTXT.Text)
        M17F = CShort(M17FTXT.Text)
        S17F = CShort(S17FTXT.Text)

        'OUT18
        H18I = CShort(H18ITXT.Text)
        M18I = CShort(M18ITXT.Text)
        S18I = CShort(S18ITXT.Text)

        H18F = CShort(H18FTXT.Text)
        M18F = CShort(M18FTXT.Text)
        S18F = CShort(S18FTXT.Text)

        'OUT19
        H19I = CShort(H19ITXT.Text)
        M19I = CShort(M19ITXT.Text)
        S19I = CShort(S19ITXT.Text)

        H19F = CShort(H19FTXT.Text)
        M19F = CShort(M19FTXT.Text)
        S19F = CShort(S19FTXT.Text)

        'OUT20
        H20I = CShort(H20ITXT.Text)
        M20I = CShort(M20ITXT.Text)
        S20I = CShort(S20ITXT.Text)

        H20F = CShort(H20FTXT.Text)
        M20F = CShort(M20FTXT.Text)
        S20F = CShort(S20FTXT.Text)

        'OUT21
        H21I = CShort(H21ITXT.Text)
        M21I = CShort(M21ITXT.Text)
        S21I = CShort(S21ITXT.Text)

        H21F = CShort(H21FTXT.Text)
        M21F = CShort(M21FTXT.Text)
        S21F = CShort(S21FTXT.Text)

        'OUT22
        H22I = CShort(H22ITXT.Text)
        M22I = CShort(M22ITXT.Text)
        S22I = CShort(S22ITXT.Text)

        H22F = CShort(H22FTXT.Text)
        M22F = CShort(M22FTXT.Text)
        S22F = CShort(S22FTXT.Text)

        'OUT23
        H23I = CShort(H23ITXT.Text)
        M23I = CShort(M23ITXT.Text)
        S23I = CShort(S23ITXT.Text)

        H23F = CShort(H23FTXT.Text)
        M23F = CShort(M23FTXT.Text)
        S23F = CShort(S23FTXT.Text)

        'OUT24
        H24I = CShort(H24ITXT.Text)
        M24I = CShort(M24ITXT.Text)
        S24I = CShort(S24ITXT.Text)

        H24F = CShort(H24FTXT.Text)
        M24F = CShort(M24FTXT.Text)
        S24F = CShort(S24FTXT.Text)

        'OUT25
        H25I = CShort(H25ITXT.Text)
        M25I = CShort(M25ITXT.Text)
        S25I = CShort(S25ITXT.Text)

        H25F = CShort(H25FTXT.Text)
        M25F = CShort(M25FTXT.Text)
        S25F = CShort(S25FTXT.Text)

        'OUT26
        H26I = CShort(H26ITXT.Text)
        M26I = CShort(M26ITXT.Text)
        S26I = CShort(S26ITXT.Text)

        H26F = CShort(H26FTXT.Text)
        M26F = CShort(M26FTXT.Text)
        S26F = CShort(S26FTXT.Text)

        'OUT27
        H27I = CShort(H27ITXT.Text)
        M27I = CShort(M27ITXT.Text)
        S27I = CShort(S27ITXT.Text)

        H27F = CShort(H27FTXT.Text)
        M27F = CShort(M27FTXT.Text)
        S27F = CShort(S27FTXT.Text)

        'OUT28
        H28I = CShort(H28ITXT.Text)
        M28I = CShort(M28ITXT.Text)
        S28I = CShort(S28ITXT.Text)

        H28F = CShort(H28FTXT.Text)
        M28F = CShort(M28FTXT.Text)
        S28F = CShort(S28FTXT.Text)

        'OUT29
        H29I = CShort(H29ITXT.Text)
        M29I = CShort(M29ITXT.Text)
        S29I = CShort(S29ITXT.Text)

        H29F = CShort(H29FTXT.Text)
        M29F = CShort(M29FTXT.Text)
        S29F = CShort(S29FTXT.Text)




        HC = Hour(TimeOfDay)
        MC = Minute(TimeOfDay)
        SC = Second(TimeOfDay)

        Final = (HFinal + HC) * 3600 + (MFinal + MC) * 60 + (SFinal + SC)

        Inicio1 = (H1I + HC) * 3600 + (M1I + MC) * 60 + (S1I + SC)
        Final1 = (H1F + HC) * 3600 + (M1F + MC) * 60 + (S1F + SC)

        Inicio2 = (H2I + HC) * 3600 + (M2I + MC) * 60 + (S2I + SC)
        Final2 = (H2F + HC) * 3600 + (M2F + MC) * 60 + (S2F + SC)

        Inicio3 = (H3I + HC) * 3600 + (M3I + MC) * 60 + (S3I + SC)
        Final3 = (H3F + HC) * 3600 + (M3F + MC) * 60 + (S3F + SC)

        Inicio4 = (H4I + HC) * 3600 + (M4I + MC) * 60 + (S4I + SC)
        Final4 = (H4F + HC) * 3600 + (M4F + MC) * 60 + (S4F + SC)

        Inicio5 = (H5I + HC) * 3600 + (M5I + MC) * 60 + (S5I + SC)
        Final5 = (H5F + HC) * 3600 + (M5F + MC) * 60 + (S5F + SC)

        Inicio6 = (H6I + HC) * 3600 + (M6I + MC) * 60 + (S6I + SC)
        Final6 = (H6F + HC) * 3600 + (M6F + MC) * 60 + (S6F + SC)

        Inicio7 = (H7I + HC) * 3600 + (M7I + MC) * 60 + (S7I + SC)
        Final7 = (H7F + HC) * 3600 + (M7F + MC) * 60 + (S7F + SC)

        Inicio8 = (H8I + HC) * 3600 + (M8I + MC) * 60 + (S8I + SC)
        Final8 = (H8F + HC) * 3600 + (M8F + MC) * 60 + (S8F + SC)

        Inicio9 = (H9I + HC) * 3600 + (M9I + MC) * 60 + (S9I + SC)
        Final9 = (H9F + HC) * 3600 + (M9F + MC) * 60 + (S9F + SC)

        Inicio10 = (H10I + HC) * 3600 + (M10I + MC) * 60 + (S10I + SC)
        Final10 = (H10F + HC) * 3600 + (M10F + MC) * 60 + (S10F + SC)

        Inicio11 = (H11I + HC) * 3600 + (M11I + MC) * 60 + (S11I + SC)
        Final11 = (H11F + HC) * 3600 + (M11F + MC) * 60 + (S11F + SC)

        Inicio12 = (H12I + HC) * 3600 + (M12I + MC) * 60 + (S12I + SC)
        Final12 = (H12F + HC) * 3600 + (M12F + MC) * 60 + (S12F + SC)

        Inicio13 = (H13I + HC) * 3600 + (M13I + MC) * 60 + (S13I + SC)
        Final13 = (H13F + HC) * 3600 + (M13F + MC) * 60 + (S13F + SC)

        Inicio14 = (H14I + HC) * 3600 + (M14I + MC) * 60 + (S14I + SC)
        Final14 = (H14F + HC) * 3600 + (M14F + MC) * 60 + (S14F + SC)

        Inicio15 = (H15I + HC) * 3600 + (M15I + MC) * 60 + (S15I + SC)
        Final15 = (H15F + HC) * 3600 + (M15F + MC) * 60 + (S15F + SC)

        Inicio16 = (H16I + HC) * 3600 + (M16I + MC) * 60 + (S16I + SC)
        Final16 = (H16F + HC) * 3600 + (M16F + MC) * 60 + (S16F + SC)

        Inicio17 = (H17I + HC) * 3600 + (M17I + MC) * 60 + (S17I + SC)
        Final17 = (H17F + HC) * 3600 + (M17F + MC) * 60 + (S17F + SC)

        Inicio18 = (H18I + HC) * 3600 + (M18I + MC) * 60 + (S18I + SC)
        Final18 = (H18F + HC) * 3600 + (M18F + MC) * 60 + (S18F + SC)

        Inicio19 = (H19I + HC) * 3600 + (M19I + MC) * 60 + (S19I + SC)
        Final19 = (H19F + HC) * 3600 + (M19F + MC) * 60 + (S19F + SC)

        Inicio20 = (H20I + HC) * 3600 + (M20I + MC) * 60 + (S20I + SC)
        Final20 = (H20F + HC) * 3600 + (M20F + MC) * 60 + (S20F + SC)

        Inicio21 = (H21I + HC) * 3600 + (M21I + MC) * 60 + (S21I + SC)
        Final21 = (H21F + HC) * 3600 + (M21F + MC) * 60 + (S21F + SC)

        Inicio22 = (H22I + HC) * 3600 + (M22I + MC) * 60 + (S22I + SC)
        Final22 = (H22F + HC) * 3600 + (M22F + MC) * 60 + (S22F + SC)

        Inicio23 = (H23I + HC) * 3600 + (M23I + MC) * 60 + (S23I + SC)
        Final23 = (H23F + HC) * 3600 + (M23F + MC) * 60 + (S23F + SC)

        Inicio24 = (H24I + HC) * 3600 + (M24I + MC) * 60 + (S24I + SC)
        Final24 = (H24F + HC) * 3600 + (M24F + MC) * 60 + (S24F + SC)

        Inicio25 = (H25I + HC) * 3600 + (M25I + MC) * 60 + (S25I + SC)
        Final25 = (H25F + HC) * 3600 + (M25F + MC) * 60 + (S25F + SC)

        Inicio26 = (H26I + HC) * 3600 + (M26I + MC) * 60 + (S26I + SC)
        Final26 = (H26F + HC) * 3600 + (M26F + MC) * 60 + (S26F + SC)

        Inicio27 = (H27I + HC) * 3600 + (M27I + MC) * 60 + (S27I + SC)
        Final27 = (H27F + HC) * 3600 + (M27F + MC) * 60 + (S27F + SC)

        Inicio28 = (H28I + HC) * 3600 + (M28I + MC) * 60 + (S28I + SC)
        Final28 = (H28F + HC) * 3600 + (M28F + MC) * 60 + (S28F + SC)

        Inicio29 = (H29I + HC) * 3600 + (M29I + MC) * 60 + (S29I + SC)
        Final29 = (H29F + HC) * 3600 + (M29F + MC) * 60 + (S29F + SC)


        'ponemos la hora actual en el cajetin HCtxt
        HCtxt.Text = CStr(TimeOfDay)

        Timer1.Enabled = True


        'inicio el sonido
        MediaPlayer1.Open("C:\belen.mp3")
        MediaPlayer1.SendToBack()



    End Sub

    Private Sub CmdStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStop.Click
        'El reproductor lo paramos
        MediaPlayer1.Stop()

        'Todos los timers los paramos
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        'todos los botones de los timers, inicio activados y Fin la desactivados 
        CmdInicio2.Enabled = True
        CmdStop2.Enabled = False
        CmdInicio3.Enabled = True
        CmdStop3.Enabled = False
        CmdInicio4.Enabled = True
        CmdStop4.Enabled = False
        'apagamos todas las salidas que se encuentren encendidas
        ClearAllIO()
        
        'apagamos todos los leds
        Led1.Visible = False
        Led2.Visible = False
        Led3.Visible = False
        Led4.Visible = False
        Led5.Visible = False
        Led6.Visible = False
        Led7.Visible = False
        Led8.Visible = False
        Led9.Visible = False
        Led10.Visible = False
        Led11.Visible = False
        Led12.Visible = False
        Led13.Visible = False
        Led14.Visible = False
        Led15.Visible = False
        Led16.Visible = False
        Led17.Visible = False
        Led18.Visible = False
        Led19.Visible = False
        Led20.Visible = False
        Led21.Visible = False
        Led22.Visible = False
        Led23.Visible = False
        Led24.Visible = False
        Led25.Visible = False
        Led26.Visible = False
        Led27.Visible = False
        Led28.Visible = False
        Led29.Visible = False
        Led30.Visible = False
        Led31.Visible = False
        Led32.Visible = False
    End Sub

    Private Sub CmdInicio2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdInicio2.Click
        parametrostimer2()
        CmdStop2.Enabled = True
    End Sub

    Private Sub CmdStop2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStop2.Click
        Timer2.Enabled = False
        ClearIOchannel(30)
        Led30.Visible = False
        CmdInicio2.Enabled = True
    End Sub
    Private Sub CmdInicio3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdInicio3.Click
        parametrostimer3()
        CmdStop3.Enabled = True
    End Sub

    Private Sub CmdStop3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStop3.Click
        Timer3.Enabled = False
        ClearIOchannel(31)
        Led31.Visible = False
        CmdInicio3.Enabled = True
    End Sub
    Private Sub CmdInicio4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdInicio4.Click
        parametrostimer4()
        CmdStop4.Enabled = True
    End Sub

    Private Sub CmdStop4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStop4.Click
        Timer4.Enabled = False
        ClearIOchannel(32)
        Led32.Visible = False
        CmdInicio4.Enabled = True
    End Sub

    Private Sub temporizador_belen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Call k8000.main_Renamed()

        'eleccion del puerto para el k8000
        k8000.SelectI2CprinterPort(1)

        'todo como salidas
        ConfigAllIOasOutput()
        'Compruebo que el fichero c:\k8000.dat exista

        Dim sContent As String = vbNullString
        Dim Cadena As String = vbNullString
        Dim Aux2 As String
        'inicializo Aux2 a 0 porque sino me da error
        Aux2 = 0
        'contador para el bocle for

        Try

            Dim SPath As String = "c:\k8000.dat"
            With My.Computer.FileSystem
                ' verifica si existe el path   
                If .FileExists(SPath) Then
                    'lee todo el contenido y asignamos los valores del fichero a los cajones de texto de la interface.  
                    sContent = .ReadAllText(SPath)
                    'sContent contiene todo el fichero
                    'MsgBox(sContent.ToString, MsgBoxStyle.Information, "Datos del Fichero")
                    Cadena = sContent.ToCharArray()
                    'MsgBox(Len(sContent), MsgBoxStyle.Information, "Longitud del Fichero")


                    'OUT1
                    H1ITXT.Text = Cadena(7) + Cadena(8)
                    M1ITXT.Text = Cadena(10) + Cadena(11)
                    S1ITXT.Text = Cadena(13) + Cadena(14)

                    H1FTXT.Text = Cadena(24) + Cadena(25)
                    M1FTXT.Text = Cadena(27) + Cadena(28)
                    S1FTXT.Text = Cadena(30) + Cadena(31)

                    'OUT2
                    H2ITXT.Text = Cadena(41) + Cadena(42)
                    M2ITXT.Text = Cadena(44) + Cadena(45)
                    S2ITXT.Text = Cadena(47) + Cadena(48)

                    H2FTXT.Text = Cadena(58) + Cadena(59)
                    M2FTXT.Text = Cadena(61) + Cadena(62)
                    S2FTXT.Text = Cadena(64) + Cadena(65)

                    'OUT3
                    H3ITXT.Text = Cadena(75) + Cadena(76)
                    M3ITXT.Text = Cadena(78) + Cadena(79)
                    S3ITXT.Text = Cadena(81) + Cadena(82)

                    H3FTXT.Text = Cadena(92) + Cadena(93)
                    M3FTXT.Text = Cadena(95) + Cadena(96)
                    S3FTXT.Text = Cadena(98) + Cadena(99)

                    'OUT4
                    H4ITXT.Text = Cadena(109) + Cadena(110)
                    M4ITXT.Text = Cadena(112) + Cadena(113)
                    S4ITXT.Text = Cadena(115) + Cadena(116)

                    H4FTXT.Text = Cadena(126) + Cadena(127)
                    M4FTXT.Text = Cadena(129) + Cadena(130)
                    S4FTXT.Text = Cadena(132) + Cadena(133)

                    'OUT5
                    H5ITXT.Text = Cadena(143) + Cadena(144)
                    M5ITXT.Text = Cadena(146) + Cadena(147)
                    S5ITXT.Text = Cadena(149) + Cadena(150)

                    H5FTXT.Text = Cadena(160) + Cadena(161)
                    M5FTXT.Text = Cadena(163) + Cadena(164)
                    S5FTXT.Text = Cadena(166) + Cadena(167)

                    'OUT6
                    H6ITXT.Text = Cadena(177) + Cadena(178)
                    M6ITXT.Text = Cadena(180) + Cadena(181)
                    S6ITXT.Text = Cadena(183) + Cadena(184)

                    H6FTXT.Text = Cadena(194) + Cadena(195)
                    M6FTXT.Text = Cadena(197) + Cadena(198)
                    S6FTXT.Text = Cadena(200) + Cadena(201)

                    'OUT7
                    H7ITXT.Text = Cadena(211) + Cadena(212)
                    M7ITXT.Text = Cadena(214) + Cadena(215)
                    S7ITXT.Text = Cadena(217) + Cadena(218)

                    H7FTXT.Text = Cadena(228) + Cadena(229)
                    M7FTXT.Text = Cadena(231) + Cadena(232)
                    S7FTXT.Text = Cadena(234) + Cadena(235)

                    'OUT8
                    H8ITXT.Text = Cadena(245) + Cadena(246)
                    M8ITXT.Text = Cadena(248) + Cadena(249)
                    S8ITXT.Text = Cadena(251) + Cadena(252)

                    H8FTXT.Text = Cadena(262) + Cadena(263)
                    M8FTXT.Text = Cadena(265) + Cadena(266)
                    S8FTXT.Text = Cadena(268) + Cadena(269)

                    'OUT9
                    H9ITXT.Text = Cadena(279) + Cadena(280)
                    M9ITXT.Text = Cadena(282) + Cadena(283)
                    S9ITXT.Text = Cadena(285) + Cadena(286)

                    H9FTXT.Text = Cadena(296) + Cadena(297)
                    M9FTXT.Text = Cadena(299) + Cadena(300)
                    S9FTXT.Text = Cadena(302) + Cadena(303)

                    'OUT10
                    H10ITXT.Text = Cadena(313) + Cadena(314)
                    M10ITXT.Text = Cadena(316) + Cadena(317)
                    S10ITXT.Text = Cadena(319) + Cadena(320)

                    H10FTXT.Text = Cadena(330) + Cadena(331)
                    M10FTXT.Text = Cadena(333) + Cadena(334)
                    S10FTXT.Text = Cadena(336) + Cadena(337)

                    'OUT11
                    H11ITXT.Text = Cadena(347) + Cadena(348)
                    M11ITXT.Text = Cadena(350) + Cadena(351)
                    S11ITXT.Text = Cadena(353) + Cadena(354)

                    H11FTXT.Text = Cadena(364) + Cadena(365)
                    M11FTXT.Text = Cadena(367) + Cadena(368)
                    S11FTXT.Text = Cadena(370) + Cadena(371)

                    'OUT12
                    H12ITXT.Text = Cadena(381) + Cadena(382)
                    M12ITXT.Text = Cadena(384) + Cadena(385)
                    S12ITXT.Text = Cadena(387) + Cadena(388)

                    H12FTXT.Text = Cadena(398) + Cadena(399)
                    M12FTXT.Text = Cadena(401) + Cadena(402)
                    S12FTXT.Text = Cadena(404) + Cadena(405)

                    'OUT13
                    H13ITXT.Text = Cadena(415) + Cadena(416)
                    M13ITXT.Text = Cadena(418) + Cadena(419)
                    S13ITXT.Text = Cadena(421) + Cadena(422)

                    H13FTXT.Text = Cadena(432) + Cadena(433)
                    M13FTXT.Text = Cadena(435) + Cadena(436)
                    S13FTXT.Text = Cadena(438) + Cadena(439)

                    'OUT14
                    H14ITXT.Text = Cadena(449) + Cadena(450)
                    M14ITXT.Text = Cadena(452) + Cadena(453)
                    S14ITXT.Text = Cadena(455) + Cadena(456)

                    H14FTXT.Text = Cadena(466) + Cadena(467)
                    M14FTXT.Text = Cadena(469) + Cadena(470)
                    S14FTXT.Text = Cadena(472) + Cadena(473)

                    'OUT15
                    H15ITXT.Text = Cadena(483) + Cadena(484)
                    M15ITXT.Text = Cadena(486) + Cadena(487)
                    S15ITXT.Text = Cadena(489) + Cadena(490)

                    H15FTXT.Text = Cadena(500) + Cadena(501)
                    M15FTXT.Text = Cadena(503) + Cadena(504)
                    S15FTXT.Text = Cadena(506) + Cadena(507)

                    'OUT16
                    H16ITXT.Text = Cadena(517) + Cadena(518)
                    M16ITXT.Text = Cadena(520) + Cadena(521)
                    S16ITXT.Text = Cadena(523) + Cadena(524)

                    H16FTXT.Text = Cadena(534) + Cadena(535)
                    M16FTXT.Text = Cadena(537) + Cadena(538)
                    S16FTXT.Text = Cadena(540) + Cadena(541)

                    'OUT17
                    H17ITXT.Text = Cadena(551) + Cadena(552)
                    M17ITXT.Text = Cadena(554) + Cadena(555)
                    S17ITXT.Text = Cadena(557) + Cadena(558)

                    H17FTXT.Text = Cadena(568) + Cadena(569)
                    M17FTXT.Text = Cadena(571) + Cadena(572)
                    S17FTXT.Text = Cadena(574) + Cadena(575)

                    'OUT18
                    H18ITXT.Text = Cadena(585) + Cadena(586)
                    M18ITXT.Text = Cadena(588) + Cadena(589)
                    S18ITXT.Text = Cadena(591) + Cadena(592)

                    H18FTXT.Text = Cadena(602) + Cadena(603)
                    M18FTXT.Text = Cadena(605) + Cadena(606)
                    S18FTXT.Text = Cadena(608) + Cadena(609)

                    'OUT19
                    H19ITXT.Text = Cadena(619) + Cadena(620)
                    M19ITXT.Text = Cadena(622) + Cadena(623)
                    S19ITXT.Text = Cadena(625) + Cadena(626)

                    H19FTXT.Text = Cadena(636) + Cadena(637)
                    M19FTXT.Text = Cadena(639) + Cadena(640)
                    S19FTXT.Text = Cadena(642) + Cadena(643)

                    'OUT20
                    H20ITXT.Text = Cadena(653) + Cadena(654)
                    M20ITXT.Text = Cadena(656) + Cadena(657)
                    S20ITXT.Text = Cadena(659) + Cadena(660)

                    H20FTXT.Text = Cadena(670) + Cadena(671)
                    M20FTXT.Text = Cadena(673) + Cadena(674)
                    S20FTXT.Text = Cadena(676) + Cadena(677)

                    'OUT21
                    H21ITXT.Text = Cadena(687) + Cadena(688)
                    M21ITXT.Text = Cadena(690) + Cadena(691)
                    S21ITXT.Text = Cadena(693) + Cadena(694)

                    H21FTXT.Text = Cadena(704) + Cadena(705)
                    M21FTXT.Text = Cadena(707) + Cadena(708)
                    S21FTXT.Text = Cadena(710) + Cadena(711)

                    'OUT22
                    H22ITXT.Text = Cadena(721) + Cadena(722)
                    M22ITXT.Text = Cadena(724) + Cadena(725)
                    S22ITXT.Text = Cadena(727) + Cadena(728)

                    H22FTXT.Text = Cadena(738) + Cadena(739)
                    M22FTXT.Text = Cadena(741) + Cadena(742)
                    S22FTXT.Text = Cadena(744) + Cadena(745)

                    'OUT23
                    H23ITXT.Text = Cadena(755) + Cadena(756)
                    M23ITXT.Text = Cadena(758) + Cadena(759)
                    S23ITXT.Text = Cadena(761) + Cadena(762)

                    H23FTXT.Text = Cadena(772) + Cadena(773)
                    M23FTXT.Text = Cadena(775) + Cadena(776)
                    S23FTXT.Text = Cadena(778) + Cadena(779)

                    'OUT24
                    H24ITXT.Text = Cadena(789) + Cadena(790)
                    M24ITXT.Text = Cadena(792) + Cadena(793)
                    S24ITXT.Text = Cadena(795) + Cadena(796)

                    H24FTXT.Text = Cadena(806) + Cadena(807)
                    M24FTXT.Text = Cadena(809) + Cadena(810)
                    S24FTXT.Text = Cadena(812) + Cadena(813)

                    'OUT25
                    H25ITXT.Text = Cadena(823) + Cadena(824)
                    M25ITXT.Text = Cadena(826) + Cadena(827)
                    S25ITXT.Text = Cadena(829) + Cadena(830)

                    H25FTXT.Text = Cadena(840) + Cadena(841)
                    M25FTXT.Text = Cadena(843) + Cadena(844)
                    S25FTXT.Text = Cadena(846) + Cadena(847)

                    'OUT26
                    H26ITXT.Text = Cadena(857) + Cadena(858)
                    M26ITXT.Text = Cadena(860) + Cadena(861)
                    S26ITXT.Text = Cadena(863) + Cadena(864)

                    H26FTXT.Text = Cadena(874) + Cadena(875)
                    M26FTXT.Text = Cadena(877) + Cadena(878)
                    S26FTXT.Text = Cadena(880) + Cadena(881)

                    'OUT27
                    H27ITXT.Text = Cadena(891) + Cadena(892)
                    M27ITXT.Text = Cadena(894) + Cadena(895)
                    S27ITXT.Text = Cadena(897) + Cadena(898)

                    H27FTXT.Text = Cadena(908) + Cadena(909)
                    M27FTXT.Text = Cadena(911) + Cadena(912)
                    S27FTXT.Text = Cadena(914) + Cadena(915)

                    'OUT28
                    H28ITXT.Text = Cadena(925) + Cadena(926)
                    M28ITXT.Text = Cadena(928) + Cadena(929)
                    S28ITXT.Text = Cadena(931) + Cadena(932)

                    H28FTXT.Text = Cadena(942) + Cadena(943)
                    M28FTXT.Text = Cadena(945) + Cadena(946)
                    S28FTXT.Text = Cadena(948) + Cadena(949)

                    'OUT29
                    H29ITXT.Text = Cadena(959) + Cadena(960)
                    M29ITXT.Text = Cadena(962) + Cadena(963)
                    S29ITXT.Text = Cadena(965) + Cadena(966)

                    H29FTXT.Text = Cadena(976) + Cadena(977)
                    M29FTXT.Text = Cadena(979) + Cadena(980)
                    S29FTXT.Text = Cadena(982) + Cadena(983)

                    'CICLOG
                    HGITXT.Text = Cadena(993) + Cadena(994)
                    MGITXT.Text = Cadena(996) + Cadena(997)
                    SGITXT.Text = Cadena(999) + Cadena(1000)

                    'CICLO1
                    H30ITXT.Text = Cadena(1010) + Cadena(1011)
                    M30ITXT.Text = Cadena(1013) + Cadena(1014)
                    S30ITXT.Text = Cadena(1016) + Cadena(1017)

                    H30FTXT.Text = Cadena(1027) + Cadena(1028)
                    M30FTXT.Text = Cadena(1030) + Cadena(1031)
                    S30FTXT.Text = Cadena(1033) + Cadena(1034)

                    HF30TXT.Text = Cadena(1044) + Cadena(1045)
                    MF30TXT.Text = Cadena(1047) + Cadena(1048)
                    SF30TXT.Text = Cadena(1050) + Cadena(1051)

                    'CICLO2
                    H31ITXT.Text = Cadena(1061) + Cadena(1062)
                    M31ITXT.Text = Cadena(1064) + Cadena(1065)
                    S31ITXT.Text = Cadena(1067) + Cadena(1068)

                    H31FTXT.Text = Cadena(1078) + Cadena(1079)
                    M31FTXT.Text = Cadena(1081) + Cadena(1082)
                    S31FTXT.Text = Cadena(1084) + Cadena(1085)

                    HF31TXT.Text = Cadena(1095) + Cadena(1096)
                    MF31TXT.Text = Cadena(1098) + Cadena(1099)
                    SF31TXT.Text = Cadena(1101) + Cadena(1102)

                    'CICLO3
                    H32ITXT.Text = Cadena(1112) + Cadena(1113)
                    M32ITXT.Text = Cadena(1115) + Cadena(1116)
                    S32ITXT.Text = Cadena(1118) + Cadena(1119)

                    H32FTXT.Text = Cadena(1129) + Cadena(1130)
                    M32FTXT.Text = Cadena(1132) + Cadena(1133)
                    S32FTXT.Text = Cadena(1135) + Cadena(1136)

                    HF32TXT.Text = Cadena(1146) + Cadena(1147)
                    MF32TXT.Text = Cadena(1149) + Cadena(1150)
                    SF32TXT.Text = Cadena(1152) + Cadena(1153)

                Else
                    'Asignamos el valor 0 a todos los cajones de texto de la Interface.
                    MsgBox("El fichero C:/K8000.dat no existe. Todos los tiempos se pondran a 0", MsgBoxStyle.Information, "Error")
                End If
            End With
            ' errores   
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Form_Terminate_Renamed()
        ClearAllDA()
        ClearAllDAC()
        ClearAllIO()
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick


        'intervalo del temporizador, 1000 milisegundos es 1 segundo
        Timer1.Interval = 1000

        H = Hour(TimeOfDay) - HC
        M = Minute(TimeOfDay) - MC
        S = Second(TimeOfDay) - SC



        HActualTxt.Text = CStr(TimeSerial(H, M, S))


        If Inicio1 < VB.Timer() And Final1 > VB.Timer() Then
            Led1.Visible = True
            SetIOchannel(1)
        Else
            Led1.Visible = False
            ClearIOchannel(1)
        End If


        If Inicio2 < VB.Timer() And Final2 > VB.Timer() Then
            Led2.Visible = True
            SetIOchannel(2)
        Else
            Led2.Visible = False
            ClearIOchannel(2)
        End If

        If Inicio3 < VB.Timer() And Final3 > VB.Timer() Then
            Led3.Visible = True
            SetIOchannel(3)
        Else
            Led3.Visible = False
            ClearIOchannel(3)
        End If

        If Inicio4 < VB.Timer() And Final4 > VB.Timer() Then
            Led4.Visible = True
            SetIOchannel(4)
        Else
            ClearIOchannel(4)
            Led4.Visible = False
        End If

        If Inicio5 < VB.Timer() And Final5 > VB.Timer() Then
            Led5.Visible = True
            SetIOchannel(5)
        Else
            ClearIOchannel(5)
            Led5.Visible = False
        End If

        If Inicio6 < VB.Timer() And Final6 > VB.Timer() Then
            Led6.Visible = True
            SetIOchannel(6)
        Else
            ClearIOchannel(6)
            Led6.Visible = False
        End If

        If Inicio7 < VB.Timer() And Final7 > VB.Timer() Then
            Led7.Visible = True
            SetIOchannel(7)
        Else
            ClearIOchannel(7)
            Led7.Visible = False
        End If


        If Inicio8 < VB.Timer() And Final8 > VB.Timer() Then
            Led8.Visible = True
            SetIOchannel(8)
        Else
            ClearIOchannel(8)
            Led8.Visible = False
        End If

        If Inicio9 < VB.Timer() And Final9 > VB.Timer() Then
            Led9.Visible = True
            SetIOchannel(9)
        Else
            ClearIOchannel(9)
            Led9.Visible = False
        End If

        If Inicio10 < VB.Timer() And Final10 > VB.Timer() Then
            Led10.Visible = True
            SetIOchannel(10)
        Else
            ClearIOchannel(10)
            Led10.Visible = False
        End If

        If Inicio11 < VB.Timer() And Final11 > VB.Timer() Then
            Led11.Visible = True
            SetIOchannel(11)
        Else
            ClearIOchannel(11)
            Led11.Visible = False
        End If

        If Inicio12 < VB.Timer() And Final12 > VB.Timer() Then
            Led12.Visible = True
            SetIOchannel(12)
        Else
            ClearIOchannel(12)
            Led12.Visible = False
        End If

        If Inicio13 < VB.Timer() And Final13 > VB.Timer() Then
            Led13.Visible = True
            SetIOchannel(13)
        Else
            ClearIOchannel(13)
            Led13.Visible = False
        End If

        If Inicio14 < VB.Timer() And Final14 > VB.Timer() Then
            Led14.Visible = True
            SetIOchannel(14)
        Else
            ClearIOchannel(14)
            Led14.Visible = False
        End If

        If Inicio15 < VB.Timer() And Final15 > VB.Timer() Then
            Led15.Visible = True
            SetIOchannel(15)
        Else
            ClearIOchannel(15)
            Led15.Visible = False
        End If

        If Inicio16 < VB.Timer() And Final16 > VB.Timer() Then
            Led16.Visible = True
            SetIOchannel(16)
        Else
            ClearIOchannel(16)
            Led16.Visible = False
        End If

        Dim entra17 As Boolean
        'entra17 = False
        Dim entra As Integer = 0

        If Inicio17 < VB.Timer() And Final17 > VB.Timer() Then
            Led17.Visible = True
            SetIOchannel(17)
        Else
            ClearIOchannel(17)
            Led17.Visible = False
        End If

        If Inicio18 < VB.Timer() And Final18 > VB.Timer() Then
            Led18.Visible = True
            SetIOchannel(18)
        Else
            ClearIOchannel(18)
            Led18.Visible = False
        End If

        If Inicio19 < VB.Timer() And Final19 > VB.Timer() Then
            Led19.Visible = True
            SetIOchannel(19)
        Else
            ClearIOchannel(19)
            Led19.Visible = False
        End If

        If Inicio20 < VB.Timer() And Final20 > VB.Timer() Then
            Led20.Visible = True
            SetIOchannel(20)
        Else
            ClearIOchannel(20)
            Led20.Visible = False
        End If

        If Inicio21 < VB.Timer() And Final21 > VB.Timer() Then
            Led21.Visible = True
            SetIOchannel(21)
        Else
            ClearIOchannel(21)
            Led21.Visible = False
        End If

        If Inicio22 < VB.Timer() And Final22 > VB.Timer() Then
            Led22.Visible = True
            SetIOchannel(22)
        Else
            ClearIOchannel(22)
            Led22.Visible = False
        End If

        If Inicio23 < VB.Timer() And Final23 > VB.Timer() Then
            Led23.Visible = True
            SetIOchannel(23)
        Else
            ClearIOchannel(23)
            Led23.Visible = False
        End If

        If Inicio24 < VB.Timer() And Final24 > VB.Timer() Then
            Led24.Visible = True
            SetIOchannel(24)
        Else
            ClearIOchannel(24)
            Led24.Visible = False
        End If

        If Inicio25 < VB.Timer() And Final25 > VB.Timer() Then
            Led25.Visible = True
            SetIOchannel(25)
        Else
            ClearIOchannel(25)
            Led25.Visible = False
        End If

        If Inicio26 < VB.Timer() And Final26 > VB.Timer() Then
            Led26.Visible = True
            SetIOchannel(26)
        Else
            ClearIOchannel(26)
            Led26.Visible = False
        End If

        If Inicio27 < VB.Timer() And Final27 > VB.Timer() Then
            Led27.Visible = True
            SetIOchannel(27)
        Else
            ClearIOchannel(27)
            Led27.Visible = False
        End If

        If Inicio28 < VB.Timer() And Final28 > VB.Timer() Then
            Led28.Visible = True
            SetIOchannel(28)
        Else
            ClearIOchannel(28)
            Led28.Visible = False
        End If

        If Inicio29 < VB.Timer() And Final29 > VB.Timer() Then
            Led29.Visible = True
            SetIOchannel(29)
        Else
            ClearIOchannel(29)
            Led29.Visible = False
        End If

        'Angel
        'If (INICIOAngel < VB.Timer() And BAJADAAngel > VB.Timer()) Or (INICIOAngel < VB.Timer() And BAJADAAngel < VB.Timer()) Then

        '    If INICIOAngel < BAJADAAngel Then

        '        res1 = (BAJADAAngel - INICIOAngel) * 435
        '        i2cmot32.SendStepCWfull(0, 10, res1)

        '    Else
        '        res2 = (INICIOAngel - BAJADAAngel) * 435
        '        i2cmot32.SendStepCWfull(0, 10, res2)
        '    End If

        'End If


        'If (PAUSAAngel < VB.Timer() And SUBIDAAngel > VB.Timer()) Or (PAUSAAngel < VB.Timer() And SUBIDAAngel < VB.Timer()) Then


        '    If PAUSAAngel < SUBIDAAngel Then

        '        res3 = (SUBIDAAngel - PAUSAAngel) * 435
        '        i2cmot32.SendStepCCWfull(0, 10, res3)

        '    Else
        '        res4 = (PAUSAAngel - SUBIDAAngel) * 435
        '        i2cmot32.SendStepCCWfull(0, 10, res4)
        '    End If


        'End If
        'Fin angel

        If Final < VB.Timer() Then
            CmdInicio.PerformClick()
        End If


    End Sub

    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        '1000 milisegundos es un segundo, el intervalo esta en segundos
        Timer2.Interval = 1000

        H30 = Hour(TimeOfDay) - HC30
        M30 = Minute(TimeOfDay) - MC30
        S30 = Second(TimeOfDay) - SC30

        Transcurrido30.Text = CStr(TimeSerial(H30, M30, S30))

        If Inicio30 < VB.Timer() And Final30 > VB.Timer() Then
            Led30.Visible = True
            SetIOchannel(30)
        Else
            ClearIOchannel(30)
            Led30.Visible = False
        End If

        If FinalCanal30 < VB.Timer() Then
            CmdInicio2.PerformClick()
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
        '1000 milisegundos es un segundo, el intervalo esta en segundos
        Timer3.Interval = 1000

        H31 = Hour(TimeOfDay) - HC31
        M31 = Minute(TimeOfDay) - MC31
        S31 = Second(TimeOfDay) - SC31

        Transcurrido31.Text = CStr(TimeSerial(H31, M31, S31))

        If Inicio31 < VB.Timer() And Final31 > VB.Timer() Then
            Led31.Visible = True
            SetIOchannel(31)
        Else
            ClearIOchannel(31)
            Led31.Visible = False
        End If

        If FinalCanal31 < VB.Timer() Then
            CmdInicio3.PerformClick()
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer4.Tick
        '1000 milisegundos es un segundo, el intervalo esta en segundos
        Timer4.Interval = 1000

        H32 = Hour(TimeOfDay) - HC32
        M32 = Minute(TimeOfDay) - MC32
        S32 = Second(TimeOfDay) - SC32

        Transcurrido32.Text = CStr(TimeSerial(H32, M32, S32))

        If Inicio32 < VB.Timer() And Final32 > VB.Timer() Then
            Led32.Visible = True
            SetIOchannel(32)
        Else
            ClearIOchannel(32)
            Led32.Visible = False
        End If

        If FinalCanal32 < VB.Timer() Then
            CmdInicio4.PerformClick()
        End If
    End Sub
    'Funcion para asignar valores y poner en marcha el timer 2
    Sub parametrostimer2()

        HFinal30 = CShort(HF30TXT.Text)
        MFinal30 = CShort(MF30TXT.Text)
        SFinal30 = CShort(SF30TXT.Text)


        H30I = CShort(H30ITXT.Text)
        M30I = CShort(M30ITXT.Text)
        S30I = CShort(S30ITXT.Text)

        H30F = CShort(H30FTXT.Text)
        M30F = CShort(M30FTXT.Text)
        S30F = CShort(S30FTXT.Text)

        HC30 = Hour(TimeOfDay)
        MC30 = Minute(TimeOfDay)
        SC30 = Second(TimeOfDay)

        FinalCanal30 = (HFinal30 + HC30) * 3600 + (MFinal30 + MC30) * 60 + (SFinal30 + SC30)

        Inicio30 = (H30I + HC30) * 3600 + (M30I + MC30) * 60 + (S30I + SC30)
        Final30 = (H30F + HC30) * 3600 + (M30F + MC30) * 60 + (S30F + SC30)

        HC30TXT.Text = CStr(TimeOfDay)
        Timer2.Enabled = True

    End Sub

    'Funcion para asignar valores y poner en marcha el timer 3
    Sub parametrostimer3()

        HFinal31 = CShort(HF31TXT.Text)
        MFinal31 = CShort(MF31TXT.Text)
        SFinal31 = CShort(SF31TXT.Text)


        H31I = CShort(H31ITXT.Text)
        M31I = CShort(M31ITXT.Text)
        S31I = CShort(S31ITXT.Text)

        H31F = CShort(H31FTXT.Text)
        M31F = CShort(M31FTXT.Text)
        S31F = CShort(S31FTXT.Text)

        HC31 = Hour(TimeOfDay)
        MC31 = Minute(TimeOfDay)
        SC31 = Second(TimeOfDay)

        FinalCanal31 = (HFinal31 + HC31) * 3600 + (MFinal31 + MC31) * 60 + (SFinal31 + SC31)

        Inicio31 = (H31I + HC31) * 3600 + (M31I + MC31) * 60 + (S31I + SC31)
        Final31 = (H31F + HC31) * 3600 + (M31F + MC31) * 60 + (S31F + SC31)

        HC31TXT.Text = CStr(TimeOfDay)
        Timer3.Enabled = True

    End Sub

    'Funcion para asignar valores y poner en marcha el timer 3
    Sub parametrostimer4()

        HFinal32 = CShort(HF32TXT.Text)
        MFinal32 = CShort(MF32TXT.Text)
        SFinal32 = CShort(SF32TXT.Text)


        H32I = CShort(H32ITXT.Text)
        M32I = CShort(M32ITXT.Text)
        S32I = CShort(S32ITXT.Text)

        H32F = CShort(H32FTXT.Text)
        M32F = CShort(M32FTXT.Text)
        S32F = CShort(S32FTXT.Text)

        HC32 = Hour(TimeOfDay)
        MC32 = Minute(TimeOfDay)
        SC32 = Second(TimeOfDay)

        FinalCanal32 = (HFinal32 + HC32) * 3600 + (MFinal32 + MC32) * 60 + (SFinal32 + SC32)

        Inicio32 = (H32I + HC32) * 3600 + (M32I + MC32) * 60 + (S32I + SC32)
        Final32 = (H32F + HC32) * 3600 + (M32F + MC32) * 60 + (S32F + SC32)

        HC32TXT.Text = CStr(TimeOfDay)
        Timer4.Enabled = True

    End Sub
    
End Class