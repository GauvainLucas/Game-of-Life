Option Explicit On
Imports System.Drawing
Imports System.IO

'---------- Projet codé par GAUVAIN Lucas et CONTAMINE Romuald -------------'
Public Class FormJeuxDeLaVie

    Dim Graph As Graphics 'Graphique dans la picturebox
    Dim Tabrect(49, 49) As Rectangle 'Tableau de 2500 cellules
    Dim Tabentier(49, 49) As Byte 'Tableau indiquant l'état des cellules (0 = morte, 1 = vivante)
    Dim Tabvoisins(49, 49) As Byte 'Tableau contenant le nombre de voisins de chaque cellule
    Dim Nbvoisins As Byte 'Nombre de voisins des cellules qui ne sont pas au bord
    Dim CelluleAffichee As Boolean = False 'Booleen indiquant si les cellules sont affichés

    Dim stylebords As New Pen(Color.Black, 0.01F) 'style des bords des cellules
    Dim CouleurRemplissageRouge As New SolidBrush(Color.Red) 'couleur des cellules vivantes
    Dim CouleurRemplissageBlanc As New SolidBrush(Color.White) 'couleur des cellules mortes

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure lancé au chargement du formulaire
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub FormJeuxDeLaVie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(200, 30)
        Me.Size = New Size(800, 640)
        Graph = PictureBoxJeux.CreateGraphics()
        Graph.PageUnit = GraphicsUnit.Pixel
        PictureBoxJeux.Size = New Size(501, 501)
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant d'afficher les 2500 cellules, toutes mortes au début
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub ButtonAfficheCarre_Click(sender As Object, e As EventArgs) Handles ButtonAfficheCarre.Click
        Dim i, j As Byte 'compteur de boucle
        If CelluleAffichee = False Then
            For i = 0 To 49
                For j = 0 To 49
                    Tabrect(i, j) = New Rectangle((PictureBoxJeux.Width - 1) / 50 * i, (PictureBoxJeux.Width - 1) / 50 * j, (PictureBoxJeux.Width - 1) / 50, (PictureBoxJeux.Width - 1) / 50)
                    Graph.DrawRectangle(stylebords, Tabrect(i, j))
                    Tabentier(i, j) = 0
                Next
            Next
            CelluleAffichee = True
        Else
            Exit Sub
        End If
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de changer l'état d'une cellule (morte ou vivante)
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub PictureBoxJeu_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxJeux.MouseClick
        Dim j, k As Byte 'coordonées de la position de la souris
        j = Int(e.X / 10)
        k = Int(e.Y / 10)

        If e.Button = MouseButtons.Left Then
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(j, k))
            Graph.DrawRectangle(stylebords, Tabrect(j, k))
            Tabentier(j, k) = 1
        End If

        If e.Button = MouseButtons.Right Then
            Graph.FillRectangle(CouleurRemplissageBlanc, Tabrect(j, k))
            Graph.DrawRectangle(stylebords, Tabrect(j, k))
            Tabentier(j, k) = 0
        End If
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de déterminer le nombre de voisins de chaque cellule
    ' Pas de paramètre
    Private Sub NombreVoisins()

        VoisinsCoinHautGauche()
        VoisinsBordHaut()
        VoisinsCoinHautDroite()
        VoisinsBordDroit()
        VoisinsCoinBasDroite()
        VoisinsCoinBasGauche()
        VoisinsBordBas()
        VoisinsBordGauche()
        CellulesAHuitVoisins()
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de compter le nombre de voisins du coin en haut à gauche
    ' Pas de paramètre
    Private Sub VoisinsCoinHautGauche()
        Dim NbvoisinsHG As Byte = 0 'nombre de voisins du coin en haut à gauche

        If Tabentier(1, 0) = 1 Then
            NbvoisinsHG += 1
        End If
        If Tabentier(1, 1) = 1 Then
            NbvoisinsHG += 1
        End If
        If Tabentier(0, 1) = 1 Then
            NbvoisinsHG += 1
        End If
        Tabvoisins(0, 0) = NbvoisinsHG
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de compter le nombre de voisins du coin en haut à droite
    ' Pas de paramètre
    Private Sub VoisinsCoinHautDroite()
        Dim NbvoisinsHD As Byte = 0 'nombre de voisins du coin en haut à droite

        If Tabentier(48, 0) = 1 Then
            NbvoisinsHD += 1
        End If
        If Tabentier(48, 1) = 1 Then
            NbvoisinsHD += 1
        End If
        If Tabentier(49, 1) = 1 Then
            NbvoisinsHD += 1
        End If
        Tabvoisins(49, 0) = NbvoisinsHD
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de compter le nombre de voisins du coin en bas à droite
    ' Pas de paramètre
    Private Sub VoisinsCoinBasDroite()
        Dim NbvoisinsBD As Byte = 0 'nombre de voisins du coin en bas a droite

        If Tabentier(49, 48) = 1 Then
            NbvoisinsBD += 1
        End If
        If Tabentier(48, 48) = 1 Then
            NbvoisinsBD += 1
        End If
        If Tabentier(48, 49) = 1 Then
            NbvoisinsBD += 1
        End If
        Tabvoisins(49, 49) = NbvoisinsBD
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de compter le nombre de voisins du coin en bas à gauche
    ' Pas de paramètre
    Private Sub VoisinsCoinBasGauche()
        Dim NbvoisinsBG As Byte = 0 'nombre de voisins du coin en bas à gauche

        If Tabentier(0, 48) = 1 Then
            NbvoisinsBG += 1
        End If
        If Tabentier(1, 48) = 1 Then
            NbvoisinsBG += 1
        End If
        If Tabentier(1, 49) = 1 Then
            NbvoisinsBG += 1
        End If
        Tabvoisins(0, 49) = NbvoisinsBG
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant de compter le nombre de voisins des cellules sauf celles se trouvant sur les bords
    ' Pas de paramètre
    Private Sub CellulesAHuitVoisins()
        Dim i, j As Byte 'compteurs de boucle

        For i = 1 To 48
            For j = 1 To 48
                Nbvoisins = 0
                If Tabentier(i - 1, j) = 1 Then
                    Nbvoisins += 1
                End If
                If Tabentier(i - 1, j - 1) = 1 Then
                    Nbvoisins += 1
                End If
                If Tabentier(i, j - 1) = 1 Then
                    Nbvoisins += 1
                End If
                If Tabentier(i + 1, j - 1) = 1 Then
                    Nbvoisins += 1
                End If
                If Tabentier(i + 1, j) = 1 Then
                    Nbvoisins += 1
                End If
                If Tabentier(i + 1, j + 1) = 1 Then
                    Nbvoisins += 1
                End If
                If Tabentier(i, j + 1) = 1 Then
                    Nbvoisins += 1
                End If
                If Tabentier(i - 1, j + 1) = 1 Then
                    Nbvoisins += 1
                End If
                Tabvoisins(i, j) = Nbvoisins
            Next
        Next
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant de compter le nombre de voisins des cellules se trouvant sur le bord haut, 
    ' coins non compris
    ' Pas de paramètre
    Private Sub VoisinsBordHaut()
        Dim i As Byte 'compteur de boucle
        For i = 1 To 48
            Nbvoisins = 0
            If Tabentier(i - 1, 0) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i + 1, 0) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i - 1, 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i, 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i + 1, 1) = 1 Then
                Nbvoisins += 1
            End If
            Tabvoisins(i, 0) = Nbvoisins
        Next
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant de compter le nombre de voisins des cellules se trouvant sur le bord bas, 
    ' coins non compris
    ' Pas de paramètre
    Private Sub VoisinsBordBas()
        Dim i As Byte 'compteur de boucle
        For i = 1 To 48
            Nbvoisins = 0
            If Tabentier(i - 1, 49) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i + 1, 49) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i - 1, 48) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i, 48) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(i + 1, 48) = 1 Then
                Nbvoisins += 1
            End If
            Tabvoisins(i, 49) = Nbvoisins
        Next
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant de compter le nombre de voisins des cellules se trouvant sur le bord droit, 
    ' coins non compris
    ' Pas de paramètre
    Private Sub VoisinsBordDroit()
        Dim i As Byte 'compteur de boucle
        For i = 1 To 48
            Nbvoisins = 0
            If Tabentier(49, i - 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(48, i - 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(48, i) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(48, i + 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(49, i + 1) = 1 Then
                Nbvoisins += 1
            End If
            Tabvoisins(49, i) = Nbvoisins
        Next
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant de compter le nombre de voisins des cellules se trouvant sur le bord gauche, 
    ' coins non compris
    ' Pas de paramètre
    Private Sub VoisinsBordGauche()
        Dim i As Byte 'compteur de boucle
        For i = 1 To 48
            Nbvoisins = 0
            If Tabentier(0, i - 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(1, i - 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(1, i) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(1, i + 1) = 1 Then
                Nbvoisins += 1
            End If
            If Tabentier(0, i + 1) = 1 Then
                Nbvoisins += 1
            End If
            Tabvoisins(0, i) = Nbvoisins
        Next
    End Sub

    ' Procédure codé par Lucas GAUVAIN et Romuald Contamine
    ' Procédure permettant de faire évoluer l'état des cellules en fonction du nombre de leur voisisns
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub ButtonEvolution_Click(sender As Object, e As EventArgs) Handles ButtonEvolution.Click
        Dim i, j As Byte 'compteurs de boucle
        NombreVoisins()
        For i = 0 To 49
            For j = 0 To 49
                If Tabentier(i, j) = 0 And Tabvoisins(i, j) = 3 Then
                    Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, j))
                    Graph.DrawRectangle(stylebords, Tabrect(i, j))
                    Tabentier(i, j) = 1
                End If
                If (Tabvoisins(i, j) = 3 Or Tabvoisins(i, j) = 2) And Tabentier(i, j) = 1 Then
                    Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, j))
                    Graph.DrawRectangle(stylebords, Tabrect(i, j))
                    Tabentier(i, j) = 1
                End If
                If (Tabvoisins(i, j) < 2 Or Tabvoisins(i, j) > 3) And Tabentier(i, j) = 1 Then
                    Graph.FillRectangle(CouleurRemplissageBlanc, Tabrect(i, j))
                    Graph.DrawRectangle(stylebords, Tabrect(i, j))
                    Tabentier(i, j) = 0
                End If
            Next
        Next
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant de rénitialiser la grille des cellules avec 2500 cellules mortes
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub ButtonRenitialiser_Click(sender As Object, e As EventArgs) Handles ButtonRenitialiser.Click
        Dim i, j As Byte 'compteurs de boucle
        For i = 0 To 49
            For j = 0 To 49
                Graph.FillRectangle(CouleurRemplissageBlanc, Tabrect(i, j))
                Graph.DrawRectangle(stylebords, Tabrect(i, j))
                Tabentier(i, j) = 0
                Tabvoisins(i, j) = 0
            Next
        Next
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de charger la configuration "Panneau"
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub PanneauToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PanneauToolStripMenuItem1.Click
        Dim i As SByte ' compteur de boucle

        For i = 24 To 26
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(25, i))
            Graph.DrawRectangle(stylebords, Tabrect(25, i))
            Tabentier(25, i) = 1
        Next
        Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(24, 25))
        Graph.DrawRectangle(stylebords, Tabrect(24, 25))
        Tabentier(24, 25) = 1

        Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(26, 24))
        Graph.DrawRectangle(stylebords, Tabrect(26, 24))
        Tabentier(26, 24) = 1
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de charger la configuration "Carré"
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub CarréToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CarréToolStripMenuItem1.Click
        Dim i, j As SByte ' compteurs de boucle

        For i = 24 To 25
            For j = 24 To 25
                Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, j))
                Graph.DrawRectangle(stylebords, Tabrect(i, j))
                Tabentier(i, j) = 1
            Next
        Next
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant de charger la configuration "Vaisseau"
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub VaisseauToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VaisseauToolStripMenuItem1.Click
        Dim i As SByte ' compteur de boucle

        For i = 24 To 26
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 25))
            Graph.DrawRectangle(stylebords, Tabrect(i, 25))
            Tabentier(i, 25) = 1
        Next
        Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(26, 24))
        Graph.DrawRectangle(stylebords, Tabrect(26, 24))
        Tabentier(26, 24) = 1
        Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(25, 23))
        Graph.DrawRectangle(stylebords, Tabrect(25, 23))
        Tabentier(25, 23) = 1
    End Sub

    ' Procédure codé par Lucas GAUVAIN et Romuald Contamine
    ' Procédure permettant de charger la configuration "Pulsar"
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub PulsarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PulsarToolStripMenuItem1.Click
        Dim i As SByte 'compteur de boucle

        For i = 21 To 23

            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 19))
            Graph.DrawRectangle(stylebords, Tabrect(i, 19))
            Tabentier(i, 19) = 1
            '
            Tabentier(19, i) = 1
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(19, i))
            Graph.DrawRectangle(stylebords, Tabrect(19, i))


            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 24))
            Graph.DrawRectangle(stylebords, Tabrect(i, 24))
            Tabentier(i, 24) = 1
            '
            Tabentier(24, i) = 1
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(24, i))
            Graph.DrawRectangle(stylebords, Tabrect(24, i))


            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 26))
            Graph.DrawRectangle(stylebords, Tabrect(i, 26))
            Tabentier(i, 26) = 1
            '
            Tabentier(26, i) = 1
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(26, i))
            Graph.DrawRectangle(stylebords, Tabrect(26, i))


            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 31))
            Graph.DrawRectangle(stylebords, Tabrect(i, 31))
            Tabentier(i, 31) = 1
            '
            Tabentier(31, i) = 1
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(31, i))
            Graph.DrawRectangle(stylebords, Tabrect(31, i))
        Next

        For i = 27 To 29

            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 19))
            Graph.DrawRectangle(stylebords, Tabrect(i, 19))
            Tabentier(i, 19) = 1
            '
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(19, i))
            Graph.DrawRectangle(stylebords, Tabrect(19, i))
            Tabentier(19, i) = 1

            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 24))
            Graph.DrawRectangle(stylebords, Tabrect(i, 24))
            Tabentier(i, 24) = 1
            '
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(24, i))
            Graph.DrawRectangle(stylebords, Tabrect(24, i))
            Tabentier(24, i) = 1

            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 26))
            Graph.DrawRectangle(stylebords, Tabrect(i, 26))
            Tabentier(i, 26) = 1
            '
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(26, i))
            Graph.DrawRectangle(stylebords, Tabrect(26, i))
            Tabentier(26, i) = 1

            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(i, 31))
            Graph.DrawRectangle(stylebords, Tabrect(i, 31))
            Tabentier(i, 31) = 1
            '
            Graph.FillRectangle(CouleurRemplissageRouge, Tabrect(31, i))
            Graph.DrawRectangle(stylebords, Tabrect(31, i))
            Tabentier(31, i) = 1
        Next
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant d'ouvrir un fichier contenant une configuration enregistré par le joueur
    ' Procédure permettant de charger la configuration "Panneau"
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Dim myStream As IO.Stream = Nothing 'spécifie le fichier en lecture
        Dim Dialogue As New OpenFileDialog() 'boite de dialogue 

        Dialogue.Filter = "jdv files (*.jdv)|*.jdv"
        Dialogue.RestoreDirectory = True

        If Dialogue.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = Dialogue.OpenFile()
                If (myStream IsNot Nothing) Then

                End If
            Catch Ex As Exception
                MessageBox.Show("Erreur à l'ouverture du fichier")
            Finally
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    ' Procédure codé par Lucas GAUVAIN
    ' Procédure permettant au joueur d'enregistrer une configuration dans un fichier 
    ' Procédure permettant de charger la configuration "Panneau"
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        Dim i, j As Byte 'compteurs de boucles
        Using Sauve As New SaveFileDialog 'boite de dialogue pour enregistrer dans un fichier 
            Sauve.Filter = "jdv files (*.jdv)|*.jdv"
            If Sauve.ShowDialog = DialogResult.OK Then
                For i = 0 To 49
                    For j = 0 To 49
                        Try
                            IO.File.WriteAllText(Tabentier(i, j), False)
                            MessageBox.Show("Sauvegardé")
                        Catch ex As Exception
                            MessageBox.Show("Erreur")
                        End Try
                    Next
                Next
            End If
        End Using
    End Sub

    ' Procédure codé par Romuald Contamine
    ' Procédure permettant de quitter l'application
    ' 2 paramètre :
    '       sender : Objet qui envoie l'information
    '       e : évènement envoyé par l'objet
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        If MsgBox("Voulez-vous quitter l'application", vbYesNo, "Quitter ?") = vbYes Then
            End
        End If
    End Sub

End Class
