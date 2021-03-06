﻿Public NotInheritable Class AboutForm

    Private Const License_URL As String = "http://www.gnu.org/licenses/gpl-2.0-standalone.html"


    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        'Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        'Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description + vbNewLine + vbNewLine
        Me.TextBoxDescription.Text += "Vortex Tracker and Vortex PT3 Player are developed by Sergey Bulba." + vbNewLine + vbNewLine
        Me.TextBoxDescription.Text += "This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version." + vbNewLine + vbNewLine
        Me.TextBoxDescription.Text += "This program Is distributed In the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details." + vbNewLine + vbNewLine
        Me.TextBoxDescription.Text += "You should have received a copy Of the GNU General Public License along With this program." + vbNewLine + "If Not, see <http: //www.gnu.org/licenses/>."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelLicense_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelLicense.LinkClicked
        System.Diagnostics.Process.Start(License_URL)
    End Sub

End Class
