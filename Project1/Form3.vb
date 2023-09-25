Public Class Form3
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.portstluciehospitalinc.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.bbrfoundation.org/faq/frequently-asked-questions-about-depression?gclid=Cj0KCQjwvL-oBhCxARIsAHkOiu3sGGkq2x_kLeaWAnvUPi03WzjgNyr94qzImYBbEp9t4sRXTAjSqgUaApxoEALw_wcB")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://gulfstudy.nih.gov/en/docs/Mental%20Health%20Questionnaire.pdf")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("
https://www.mhinnovation.net/sites/default/files/downloads/innovation/tools/Survey-questionnaire-CHWs-2013.pdf
")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub
End Class