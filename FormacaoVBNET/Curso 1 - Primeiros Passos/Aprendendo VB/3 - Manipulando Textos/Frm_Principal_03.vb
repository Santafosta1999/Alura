Public Class Frm_Principal_03

    Dim ListaCurso As String

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_NomeProjeto.Text = "3 - Manipulando Textos"
        Btm_Principal.Text = "Clique para ver os resultados"
        Me.Text = "3 - Manipulando Textos"
        Btm_Char.Text = "Clique para obter o char"
        Lbl_Curso.Text = "Digite o seu curso preferido"
        Btm_Adicionar.Text = "Adicione a sua lista"
        Btm_MostraLista.Text = "Mostra a lista atual"
        Btm_GuardarVariaveis.Text = "Clique aqui"


    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim PrimeiraLetra As Char = "a"
        MsgBox("O caracter da variável PrimeiraLetra é " + PrimeiraLetra)

        Dim SegundaLetra As Char = Chr(65)
        MsgBox("O caracter número 65 é " + SegundaLetra)

        Dim NumeroChar As Integer
        NumeroChar = 65
        Dim TerceiraLetra As Char = Chr(NumeroChar)

        NumeroChar = NumeroChar + 1
        Dim QuartaLetra As Char = Chr(NumeroChar)

        MsgBox("O caracter número 65 é " + TerceiraLetra + " e o 66 é " + QuartaLetra)

    End Sub

    Private Sub Btm_Char_Click(sender As Object, e As EventArgs) Handles Btm_Char.Click

        Dim ValorChar As Integer = Val(Txt_Numero_Char.Text)
        Dim QuintaLetra As Char = Chr(ValorChar)

        MsgBox("O caracter para o número " + ValorChar.ToString + " é " + QuintaLetra)

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        Dim CursoDigitado As String = Txt_Curso.Text
        ListaCurso = ListaCurso + CursoDigitado + vbCrLf
        Txt_Lista.Text = ListaCurso

    End Sub

    Private Sub Btm_MostraLista_Click(sender As Object, e As EventArgs) Handles Btm_MostraLista.Click

        MsgBox(ListaCurso)

    End Sub

    Private Sub Btm_GuardarVariaveis_Click(sender As Object, e As EventArgs) Handles Btm_GuardarVariaveis.Click

        Dim idade As Integer = 32
        Dim idadeGustavo As Integer

        idadeGustavo = idade

        MsgBox("Idade é igua a " + idade.ToString + " enquanto a idadeGustavo é " + idadeGustavo.ToString)

        idade = 20

        MsgBox("Idade é igua a " + idade.ToString + " enquanto a idadeGustavo é " + idadeGustavo.ToString)


    End Sub
End Class
