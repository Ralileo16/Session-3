Imports System.IO
Imports System.Net.Sockets
Imports Microsoft.Data
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity
Imports Microsoft.IdentityModel.Tokens
Imports Newtonsoft.Json

Public Class Form1
    Public MDIChildfrmProgramme As frmProgramme
    Public MDIChildfrmEtudiant As frmEtudiant

    Private cn As SqlConnection
    Private ds As DataSet

    Private ProgrammeSqlAdapter As SqlDataAdapter
    Private StudentSqlAdapter As SqlDataAdapter

    Private cmdSelectStudents As SqlCommand
    Private cmdSelectProgramme As SqlCommand

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MDIChildfrmProgramme = New frmProgramme()
        MDIChildfrmEtudiant = New frmEtudiant()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserConnexionCommandes()
    End Sub

    Private Sub InitialiserConnexionCommandes()
        Try
            cn = New SqlConnection(My.Settings.cnp44)
        Catch sqlEx As SqlException
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & sqlEx.Number & ":: " & sqlEx.Message)
            Environment.Exit(0)
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu lors de l'ouveture de la connexion au serveur de base de données:: " & ex.Message)
            Environment.Exit(0)
        End Try

        cmdSelectStudents = New SqlCommand("SELECT * FROM T_etudiants", cn)

        cmdSelectProgramme = New SqlCommand("SELECT * FROM T_programme", cn)

        StudentSqlAdapter = New SqlDataAdapter(cmdSelectStudents)
        ProgrammeSqlAdapter = New SqlDataAdapter(cmdSelectProgramme)

        ds = New DataSet("tp_p44")
        ProgrammeSqlAdapter.Fill(ds, "T_programme")
        StudentSqlAdapter.Fill(ds, "T_etudiants")
    End Sub
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ProgrammeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammeToolStripMenuItem.Click
        If ActiveMdiChild() IsNot MDIChildfrmProgramme Or ActiveMdiChild() Is Nothing Then
            For Each MdiChild As Form In MdiChildren()
                MdiChild.Hide()
            Next
            MDIChildfrmProgramme.MdiParent = Me
            MDIChildfrmProgramme.Show()
            ActiveMdiChild.Anchor = AnchorStyles.Top And AnchorStyles.Left
            ActiveMdiChild.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub ÉtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉtudiantsToolStripMenuItem.Click
        If ActiveMdiChild() IsNot MDIChildfrmEtudiant Or ActiveMdiChild() Is Nothing Then
            For Each MdiChild As Form In MdiChildren()
                MdiChild.Hide()
            Next
            MDIChildfrmEtudiant.MdiParent = Me
            MDIChildfrmEtudiant.Show()
            ActiveMdiChild.Anchor = AnchorStyles.Top And AnchorStyles.Left
            ActiveMdiChild.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub ListeDesProgrammesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesProgrammesToolStripMenuItem.Click
        ds.Clear()

        ProgrammeSqlAdapter.Fill(ds, "T_programme")
        StudentSqlAdapter.Fill(ds, "T_etudiants")

        Dim table As DataTable = ds.Tables("T_programme")

        Dim json As String = JsonConvert.SerializeObject(table)

        Dim reportsPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rapports")

        If Not Directory.Exists(reportsPath) Then
            Directory.CreateDirectory(reportsPath)
        End If

        Dim reportPath As String = Path.Combine(reportsPath, "rapport.html")

        Dim html As String = $"
        <!doctype html>
        <html lang='fr'>
        <head>
            <meta charset='utf-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1'>
            <title>Rapport</title>
        </head>
        <body>
            <h1>Rapport Programme</h1>
            <div id='content'>
            </div>

            <script>
                let data = JSON.parse('{json}');
                let content = document.getElementById('content');

                let htmlTable = document.createElement('table');

                htmlTable.style.width = '90%';
                htmlTable.style.margin = '1em auto 1em auto';

                let htmlHead = document.createElement('thead');
                let htmlRow = document.createElement('tr');
                htmlHead.style.height = '1.5 em';
                htmlRow.style.height = '1.5 em';

                let htmlTableheader;
                let props = Object.keys(data[0]);
                
                props.forEach(prop => {{ 
                    htmlTableheader = document.createElement('th');
                    htmlTableheader.innerText = prop;
                    htmlTableheader.style.textAlign = 'left';
                    htmlRow.appendChild(htmlTableheader);
                }});

                htmlHead.appendChild(htmlRow);
                htmlTable.appendChild(htmlHead);
                
                let htmlTableBody = document.createElement('tbody');
                let htmlTableData;

                data.forEach(programme => {{ 
                    htmlRow = document.createElement('tr');
                    let programmeProps = Object.values(programme);
                    
                    programmeProps.forEach(propProgramme => {{ 
                        htmlTableData = document.createElement('td');
                        htmlTableData.innerText = propProgramme?.toString() ?? '';
                        htmlRow.appendChild(htmlTableData);
                    }});
                    
                    htmlTableBody.appendChild(htmlRow);
                }});
                htmlTable.appendChild(htmlTableBody);

                content.appendChild(htmlTable);
            </script>
         </body>
        </html>
"

        File.WriteAllText(reportPath, html)
        Process.Start(New ProcessStartInfo(reportPath) With {
            .UseShellExecute = True
        })
    End Sub

    Private Sub ListeDesEtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesÉtudiantsToolStripMenuItem.Click
        ds.Clear()

        ProgrammeSqlAdapter.Fill(ds, "T_programme")
        StudentSqlAdapter.Fill(ds, "T_etudiants")

        Dim table As DataTable = ds.Tables("T_etudiants")

        Dim json As String = JsonConvert.SerializeObject(table)

        Dim reportsPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rapports")

        If Not Directory.Exists(reportsPath) Then
            Directory.CreateDirectory(reportsPath)
        End If

        Dim reportPath As String = Path.Combine(reportsPath, "rapport.html")

        Dim html As String = $"
        <!doctype html>
        <html lang='fr'>
        <head>
            <meta charset='utf-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1'>
            <title>Rapport</title>
        </head>
        <body>
            <h1>Rapport Étudiants</h1>
            <div id='content'>
            </div>

            <script>
                let data = JSON.parse('{json}');
                console.log('{json}')
                let content = document.getElementById('content');

                let htmlTable = document.createElement('table');

                htmlTable.style.width = '90%';
                htmlTable.style.margin = '1em auto 1em auto';

                let htmlHead = document.createElement('thead');
                let htmlRow = document.createElement('tr');
                htmlHead.style.height = '1.5 em';
                htmlRow.style.height = '1.5 em';

                let htmlTableheader;
                let props = Object.keys(data[0]);
                
                props.forEach(prop => {{ 
                    htmlTableheader = document.createElement('th');
                    htmlTableheader.innerText = prop;
                    htmlTableheader.style.textAlign = 'left';
                    htmlRow.appendChild(htmlTableheader);
                }});

                htmlHead.appendChild(htmlRow);
                htmlTable.appendChild(htmlHead);
                
                let htmlTableBody = document.createElement('tbody');
                let htmlTableData;

                 data.forEach(student => {{ 
                    htmlRow = document.createElement('tr');
                    let studentProps = Object.values(student);
                    
                    studentProps.forEach(propStudent => {{ 
                        htmlTableData = document.createElement('td');
                        htmlTableData.innerText = propStudent?.toString() ?? '';
                        htmlRow.appendChild(htmlTableData);
                    }});
                    
                    htmlTableBody.appendChild(htmlRow);
                }});
                htmlTable.appendChild(htmlTableBody);

                content.appendChild(htmlTable);
            </script>
         </body>
        </html>
"

        File.WriteAllText(reportPath, html)
        Process.Start(New ProcessStartInfo(reportPath) With {
            .UseShellExecute = True
        })
    End Sub

    Private Sub ListeDesEtudiantsParProgrammeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesÉtudiantsParProgrammeToolStripMenuItem.Click
        ds.Clear()

        ProgrammeSqlAdapter.Fill(ds, "T_programme")
        StudentSqlAdapter.Fill(ds, "T_etudiants")

        Dim table As DataTable = ds.Tables("T_etudiants")

        Dim json As String = JsonConvert.SerializeObject(table)

        Dim reportsPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rapports")

        If Not Directory.Exists(reportsPath) Then
            Directory.CreateDirectory(reportsPath)
        End If

        Dim reportPath As String = Path.Combine(reportsPath, "rapport.html")

        Dim html As String = $"
            <!doctype html>
<html lang='fr'>
<head>
	<meta charset='utf-8'>
	<meta name='viewport' content='width=device-width, initial-scale=1'>
	<title>Rapport</title>
	<style>
		table {{
			width: 90%;
			margin: 1em auto;
			border-collapse: collapse;
		}}
		th, td {{
			border: 1px solid black;
			padding: 0.5em;
			text-align: left;
		}}
		th {{
			background-color: #f2f2f2;
		}}
		.program {{
			margin: 2em 0;
		}}
		.program h2 {{
			text-align: center;
			margin-top: 2em;
		}}
	</style>
</head>
<body>
	<h1>Rapport Étudiants</h1>
	<div id='content'></div>
	
	<script>
		let data = JSON.parse('{json}');
		let content = document.getElementById('content');
		console.log(data)
		
		let proNoSet = new Set();
		
		data.forEach(student => {{
			proNoSet.add(student.pro_no);
		}});
		
		console.log(proNoSet)
		
		proNoSet.forEach(prog => {{
			let title = document.createElement('h3');
			title.innerHTML = prog
			content.appendChild(title)
			let htmlTable = document.createElement('table');
			
			htmlTable.style.width = '90%';
			htmlTable.style.margin = '1em auto 1em auto';
			
			let htmlHead = document.createElement('thead');
			let htmlRow = document.createElement('tr');
			htmlHead.style.height = '1.5 em';
			htmlRow.style.height = '1.5 em';
			
			let htmlTableheader;
			let props = Object.keys(data[0]);
			
			props.forEach(prop => {{ 
				htmlTableheader = document.createElement('th');
				htmlTableheader.innerText = prop;
				htmlTableheader.style.textAlign = 'left';
				htmlRow.appendChild(htmlTableheader);
			}});
			
			htmlHead.appendChild(htmlRow);
			htmlTable.appendChild(htmlHead);
			
			let htmlTableBody = document.createElement('tbody');
			let htmlTableData;
			
			data.forEach(student => {{
				if(student.pro_no == prog) {{
					htmlRow = document.createElement('tr');
					let studentProps = Object.values(student);
					
					studentProps.forEach(propStudent => {{ 
						htmlTableData = document.createElement('td');
						htmlTableData.innerText = propStudent?.toString() ?? '';
						htmlRow.appendChild(htmlTableData);
						
					}});
					
					htmlTableBody.appendChild(htmlRow);
				}}
			}});
			htmlTable.appendChild(htmlTableBody);
			
			content.appendChild(htmlTable);
		}})
	</script>
</body>
</html>"

        File.WriteAllText(reportPath, html)
        Process.Start(New ProcessStartInfo(reportPath) With {
        .UseShellExecute = True
    })
    End Sub



End Class
