Imports System.Management.Automation

Namespace ShowGreetings
    ' Declare class as cmdlet 
    <Cmdlet(VerbsCommon.Show, "Greeting")> _
    Public Class ShowGreetingCmdlet 
        Inherits PSCmdlet
        
        ' Parameter for the cmdlet
        Private _Name As String()
        <Parameter(Mandatory:=True,Position:=1)> _
        Public Property Name() As String()
            Get 
                Return _Name
            End Get
            Set(ByVal value As String())
                _Name = value
            End Set
        End Property

        ' Overide the ProcessRecord method to process
        ' the parameter and write object
        Protected Overrides Sub ProcessRecord()
            ' Convert _Name to String
            Dim strName As String = String.Join("", _Name)
            WriteObject("Hello " + strName + "!")
        End Sub
    End Class
End Namespace
