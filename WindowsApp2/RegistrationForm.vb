

Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class RegistrationForm
    Private birthOfPlaceCode As String()() = New String()() {New String() {"01", "21", "22", "23", "24"}, New String() {"02", "25", " 26", "27"},
        New String() {"03", "28", "29"}, New String() {"04", "30"}, New String() {"05", "31", "59"}, New String() {"06", "32", "33"},
        New String() {"07", "34", "35"}, New String() {"08", "36", "37", "38", "39"}, New String() {"09", "40"}, New String() {"10", "41", "42", "43", "44"},
        New String() {"11", "45", "46"}, New String() {"12", "47", "48", "49"}, New String() {"13", "50", "51", "52", "53"},
        New String() {"14", "54", "55", "56", "57"}, New String() {"15", "58"}, New String() {"16"}, New String() {"82"}}

    'Country List
    Private cultureList As New List(Of String)()
    Private cultures As CultureInfo() = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
    Private region As RegionInfo
    Private state() As String = {"Selangor", "Kuala Lumpur", "Terengganu", "Sarawak", "Sabah", "Penang", "Perlis", "Perak", "Pahang", "Negeri Sembilan", "Malacca", "Kelantan", "Kedah", "Johor"}
    Private city As String()() = New String()() {New String() {"Ampang", "Bandar Baru Bangi", "Bandar Puncak Alam", "Bangi", "Banting", "Batang Berjuntai", "Batang Kali", "Batangkali", "Batu Arang", "Batu Caves", "Beranang", "Bukit Rotan",
        "Cheras", "Cyberjaya", "Dengkil", "Gombak", "Hulu Langat", "Jenjarom", "Jeram", "Kajang", "Kapar", "Klang", "Klia", "Kuala Kubu Baru", "Kuala Selangor", "Kuantan", "Pandan", "Pelabuhan Klang", "Petaling Jaya", "Puchong",
    "Pulau Carey", "Pulau Indah", "Pulau Ketam", "Rasa", "Rawang", "Sabak Bernam", "Sekinchan", "Semenyih", "Sepang", "Serdang", "Serendah", "Seri Kembangan", "Shah Alam", "Subang Airport", "Subang Jaya", "Sungai Ayer Tawar", "Sungai Besar",
    "Sungai Buloh", "Sungai Pelek", "Tanjong Karang", "Tanjong Sepat", "Telok Panglima Garang"},
                                New String() {"Ampang", "Batu Caves", "Cheras", "Damansara", "Gombak", "Hulu Kelang", "Kepong", "Kuala Lumpur", "Petaling", "Petaling Jaya", "Sentul", "Setapak", "Sungai Besi"},
                                New String() {"Ajil", "Al Muktatfi Billah Shah", "Ayer Puteh", "Bukit Besi", "Bukit Payong", "Ceneh", "Chalok", "Cukai", "Dungun", "Jerteh", "Kampung Raja", "Kemasek", "Kerteh", "Ketengah Jaya", "Kijal", "Kuala Berang", "Kuala Besut", "Kuala Terengganu", "Marang", "Paka", "Permaisuri", "Sungai Tong"},
                                New String() {"Asajaya", "Balingian", "Baram", "Bau", "Bekenu", "Belaga", "Belawai", "Betong", "Bintangor", "Bintulu", "Dalat", "Daro", "Debak", "Engkilili", "Julau", "Kabong",
                            "Kanowit", "Kapit", "Kota Samarahan", "Kuching", "Lawas", "Limbang", "Lingga", "Long Lama", "Lubok Antu", "Lundu", "Lutong", "Matu", "Miri", "Mukah", "Nanga Medamit", "Niah",
                            "Pusa", "Roban", "Saratok", "Sarikei", "Sebauh", "Sebuyau", "Serian", "Sibu", "Siburan", "Simunjan", "Song", "Spaoh", "Sri Aman", "Sundar", "Tatau"},
                            New String() {"Beaufort", "Beluran", "Beverly", "Bongawan", "Inanam", "Keningau", "Kota Belud", "Kota Kinabalu", "Kota Kinabatangan", "Kota Marudu", "Kuala Penyu", "Kudat",
                        "Kunak", "Lahad Datu", "Likas", "Membakut", "Menumbok", "Nabawan", "Pamol", "Papar", "Penampang", "Putatan", "Ranau", "Sandakan", "Semporna", "Sipitang", "Tambunan", "Tamparuli", "Tanjung Aru", "Tawau", "Tenghilan", "Tenom", "Tuaran"},
                            New String() {"Ayer Itam", "Balik Pulau", "Batu Ferringhi", "Batu Maung", "Bayan Lepas", "Bukit Mertajam", "Butterworth", "Gelugor", "Jelutong", "Kepala Batas", "Kubang Semang", "Nibong Tebal", "Penaga", "Penang Hill", "Perai", "Permatang Pauh", "Pulau Pinang", "Simpang Ampat", "Sungai Jawi", "Tanjong Bungah", "Tanjung Bungah", "Tasek Gelugor", "Tasek Gelugur", "USM Pulau Pinang"},
                            New String() {"Arau", "Kaki Bukit", "Kangar", "Kuala Perlis", "Padang Besar", "Simpang Ampat"},
                            New String() {"Ayer Tawar", "Bagan Datoh", "Bagan Serai", "Bandar Seri Iskandar", "Batu Gajah", "Batu Kurau", "Behrang Stesen", "Bidor", "Bota", "Bruas", "Changkat Jering",
 "Changkat Keruing", "Chemor", "Chenderiang", "Chenderong Balai", "Chikus", "Enggor", "Gerik", "Gopeng", "Hutan Melintang", "Intan", "Ipoh", "Jeram", "Kampar", "Kampung Gajah", "Kampung Kepayang",
    "Kamunting", "Kuala Kangsar", "Kuala Kurau", "Kuala Sepetang", "Lambor Kanan", "Langkap", "Lenggong", "Lumut", "Malim Nawar", "Manong", "Matang", "Padang Rengas", "Pangkor", "Pantai Remis", "Parit",
    "Parit Buntar", "Pengkalan Hulu", "Pusing", "Rantau Panjang", "Sauk", "Selama", "Selekoh", "Seri Manjong", "Seri Manjung", "Simpang", "Simpang Ampat Semanggol", "Sitiawan", "Slim River", "Sungai Siput",
    "Sungai Sumun", "Sungkai", "Taiping", "Tanjong Malim", "Tanjong Piandang", "Tanjong Rambutan", "Tanjong Tualang", "Tapah", "Tapah Road", "Teluk Intan", "Temoh", "TLDM Lumut", "Trolak",
    "Trong", "Tronoh", "Ulu Bernam", "Ulu Kinta"},
     New String() {"Balok", "Bandar Bera", "Bandar Pusat Jengka", "Bandar Pusat Jengka", "Bandar Tun Abdul Razak", "Benta", "Bentong", "Brinchang", "Bukit Fraser", "Bukit Goh", "Bukit Kuin", "Chenor", "Chini", "Damak",
    "Dong", "Gambang", "Genting Highlands", "Cameron Highlands", "Jerantut", "Karak", "Kemayan", "Kuala Krau", "Kuala Lipis", "Kuala Rompin", "Kuantan", "Lanchang", "Lurah Bilut", "Maran", "Mentakab", "Muadzam Shah", "Padang Tengku",
    "Pekan", "Raub", "Ringlet", "Sega", "Sungai Koyan", "Sungai Lembing", "Tanah Rata", "Temerloh", "Triang"},
    New String() {"Bahau", "Bandar Enstek", "Bandar Seri Jempol", "Batu Kikir", "Gemas", "Gemencheh", "Johol", "Kota", "Kuala Klawang", "Kuala Pilah", "Labu", "Linggi", "Mantin", "Nilai", "Port Dickson",
    "Pusat Bandar Palong", "Rantau", "Rembau", "Rompin", "Seremban", "Si Rusa", "Simpang Durian", "Simpang Pertang", "Tampin", "Tanjong Ipoh"},
    New String() {"Alor Gajah", "Asahan", "Ayer Keroh", "Bemban", "Durian Tunggal", "Jasin", "Kem Trendak", "Kuala Sungai Baru", "Lubok China", "Masjid Tanah", "Melaka", "Merlimau", "Selandar", "Sungai Rambai", "Sungai Udang", "Tanjong Kling"},
    New String() {"Ayer Lanas", "Bachok", "Cherang Ruku", "Dabong", "Gua Musang", "Jeli", "Kem Desa Pahlawan", "Ketereh", "Kota Bharu", "Kuala Balah", "Kuala Krai", "Machang", "Melor", "Pasir Mas",
    "Pasir Puteh", "Pulai Chondong", "Rantau Panjang", "Selising", "Tanah Merah", "Temangan", "Tumpat", "Wakaf Bharu"},
    New String() {"Alor Tajar", "Anak Bukit", "Baling", "Bedong", "Bukit Kayu Hitam", "Bukit Pinang", "Bukit Selambau", "Changlun", "Durian Burung", "Guar Chempedak", "Gurun", "Jeniang", "Jitra", "Kepala Batas", "Kodiang", "Kota Sarang Semut", "Kuah", "Kuala Kedah", "Kuala Ketil", "Kuala Nerang", "Kuala Pegang", "Kulim,Kupang", "Kedah", "Langgar", "Lunas", "Megat Dewa", "Merbok", "Padang Matsirat", "Padang Serai", "Pendang", "Pokok Sena", "Semeling", "Serdang", "Sik", "Sintok", "Sungai Lalang", "Sungai Limau", "Sungai Petani", "Tanjung Dawai", "Tokai", "Yan"},
    New String() {"Ayer Baloi", "Ayer Hitam", "Ayer Tawar 2", "Bandar Penawar", "Bandar Tenggara", "Batu Anam", "Batu Pahat", "Bekok", "Benut", "Bukit Gambir", "Bukit Pasir", "Chaah", "Endau", "Gelang Patah", "Gerisek",
    "Gugusan Taib Andak", "Jementah", "Johor Bahru", "Kahang", "Kluang", "Kota Tinggi", "Kukup", "Kulai", "Labis", "Layang-Layang", "Masai", "Mersing", "Muar", "Nusajaya", "Pagoh", "Paloh", "Panchor",
    "Parit Jawa", "Parit Raja", "Parit Sulong", "Pasir Gudang", "Pekan Nenas", "Pengerang", "Pontian", "Pulau Satu", "Rengam", "Rengit", "Segamat", "Semerah", "Senai", "Senggarang", "Seri Gading",
    "Seri Medan", "Simpang Rengam", "Sungai Mati", "Tangkak", "Ulu Tiram", "Yong Peng"}}
    Private Property moveForm As Boolean
    Private Property moveForm_MousePosition As Point
    Private year As Integer
    Private picBox As New PictureBox
    Private conn = New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
    Private command As MySqlCommand
    Private sql As String
    Private reader As MySqlDataReader
    Public isVerified As Boolean = False


    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set form border to none
        Me.FormBorderStyle = FormBorderStyle.None
        'round form border
        roundCornerModule.roundCorner(Me)

        'setting date picker format and max date to current date
        dateDOB.Format = DateTimePickerFormat.Custom
        dateDOB.CustomFormat = "dd/MM/yyyy"
        dateDOB.MaxDate = Date.Now()

        'country list 
        For Each culture As CultureInfo In cultures
            region = New RegionInfo(culture.LCID)
            If Not (cultureList.Contains(region.EnglishName)) Then
                cultureList.Add(region.EnglishName)
                cbxCountry.Items.Add(region.EnglishName)
            End If
        Next

        panelRegistration1.Visible = True
        panelRegistration1.BringToFront()
        cbxState.Items.AddRange(state)

        Try
            conn.Open()
            sql = "SELECT programmeName FROM Programme"
            command = New MySqlCommand(sql, conn)
            reader = command.ExecuteReader()

            While reader.Read
                cbxProgramme.Items.Add(reader.GetString("programmeName"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub


    'BACK Button 
    Private Sub btnRegisterBack_Click(sender As Object, e As EventArgs) Handles btnRegisterBack.Click
        panelRegistration2.Visible = False
        panelRegistration1.Visible = True
    End Sub

    'Toggle passport checkbox and ic checkbox
    Private Sub chkbxIC_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxIC.CheckedChanged
        chkBxICIsChecked()
    End Sub
    Private Sub chkbxPassport_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxPassport.CheckedChanged
        chkBxPassIsChecked()
    End Sub

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged
        validateCountry()
    End Sub
    Private Sub validateCountry()
        setWarningIconPadding(errorCountry, cbxCountry, 8)

        If cbxCountry.SelectedIndex > 0 Then
            If chkbxIC.Checked Then
                If cbxCountry.SelectedItem.Equals("Malaysia") Then
                    setSuccessMsg(errorCountry, cbxCountry, "Success")
                Else
                    setErrorMsg(errorCountry, cbxCountry, "Please select Malaysia for IC field")
                End If
            ElseIf chkbxPassport.Checked Then
                If cbxCountry.SelectedIndex >= 0 Then
                    setSuccessMsg(errorCountry, cbxCountry, "Success")
                Else
                    setErrorMsg(errorCountry, cbxCountry, "Please select a country")
                End If
            End If
        Else
            setErrorMsg(errorCountry, cbxCountry, "Please select a country")
        End If
    End Sub






    'validate name
    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        validateName()
    End Sub

    'validate email
    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        validateEmail()
    End Sub

    'validate prefix
    Private Sub cbxPrefixContact_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbxPrefixContact.Validating
        If validatePrefixContact() Then
            validateContact()
        Else
            setErrorMsg(errorContact, txtContact, "Please Select a prefix")
        End If
    End Sub

    'validate phone number
    Private Sub txtContact_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContact.Validating
        errorContact.SetIconPadding(txtContact, 8)

        If validatePrefixContact() Then
            validateContact()
        Else
            setErrorMsg(errorContact, txtContact, "Please Select a prefix")
        End If
    End Sub

    Private Sub dateDOB_ValueChanged(sender As Object, e As EventArgs) Handles dateDOB.ValueChanged

        Dim day As String = dateDOB.Value.Day
        Dim month As String = dateDOB.Value.Month
        Dim year As String = dateDOB.Value.Year
        If day.Length = 1 Then
            day = "0" & day
        End If
        If month.Length = 1 Then
            month = "0" & month
        End If
        If checkLength(txtICFront, 6) Then
            txtICFront.Text = year.Substring(2, 2) & month & day
        End If

        validateAge()
    End Sub

    'validate passport
    Private Sub txtPassport_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassport.Validating
        validatePassport()
    End Sub

    'validate whole IC
    Private Sub ic_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtICMiddle.Validating, txtICFront.Validating, txtICBack.Validating

        validateIC()
    End Sub
    Private Sub validateIC()
        setWarningIconPadding(errorIC, txtICBack, 8)

        'check is there any null value in textfield
        If checkNullField(txtICFront) And checkNullField(txtICMiddle) And checkNullField(txtICBack) Then
            'check length for each textfield of ic
            If checkLength(txtICFront, 6) And checkLength(txtICMiddle, 2) And checkLength(txtICBack, 4) Then
                If txtICFront.Text Like "######" And txtICMiddle.Text Like "##" And txtICBack.Text Like "####" Then
                    If checkDOBIC(txtICFront) Then
                        dateDOB.Value = New DateTime(Me.year, Integer.Parse(txtICFront.Text.Substring(2, 2)), Integer.Parse(txtICFront.Text.Substring(4, 2)))
                        If checkPOBIC(txtICMiddle) Then
                            setSuccessMsg(errorIC, txtICBack, "Success")
                            validateAge()
                            If Integer.Parse(txtICBack.Text.Substring(3, 1)) Mod 2 = 0 Then
                                rBtnFemale.Checked = True
                            ElseIf Integer.Parse(txtICBack.Text.Substring(3, 1)) Mod 2 <> 0 Then
                                rBtnMale.Checked = True
                            End If
                        Else
                            setErrorMsg(errorIC, txtICBack, "Invalid Place of Birth")
                        End If
                    Else
                        setErrorMsg(errorIC, txtICBack, "Invalid Date of Birth")
                    End If
                Else
                    setErrorMsg(errorIC, txtICBack, "No alphabet or symbol is allowed")
                End If
            Else
                setErrorMsg(errorIC, txtICBack, "Invalid IC length")
            End If
        Else
            setErrorMsg(errorIC, txtICBack, "Please fill in your IC")
        End If
    End Sub
    'Check for Place of Birth
    Private Function checkPOBIC(txtBox As TextBox) As Boolean

        Dim isValid As Boolean = False

        For i = 0 To birthOfPlaceCode.GetUpperBound(0)
            For j = 0 To birthOfPlaceCode(i).GetUpperBound(0)
                If txtBox.Text.Trim = birthOfPlaceCode(i)(j).Trim Then
                    isValid = True
                    Exit For
                Else
                    isValid = False
                End If
            Next
            If isValid Then
                Exit For
            End If
        Next

        Return isValid
    End Function
    'check for Date of Birth
    Private Function checkDOBIC(txtBox As TextBox) As Boolean
        Dim today As New Date
        Dim todayYear As String = today.Now.Year.ToString()
        Dim month As Integer = Integer.Parse(txtBox.Text.Substring(2, 2))
        Dim day As Integer = Integer.Parse(txtBox.Text.Substring(4, 2))
        Me.year = Integer.Parse(todayYear.Substring(0, 2) & txtBox.Text.Substring(0, 2))
        Dim isLeapYear As Boolean = False
        Dim isValid As Boolean = False

        If Integer.Parse(todayYear) - year < 0 Then
            year -= 100
        End If

        If month > 0 And month <= 12 Then
            isValid = True
            Select Case month
                Case 1
                    If day >= 1 And day <= 31 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 2
                    isLeapYear = Date.IsLeapYear(year)
                    If isLeapYear Then
                        If day >= 1 And day <= 29 Then
                            isValid = True
                        Else
                            isValid = False
                        End If
                    Else
                        If day >= 1 And day <= 28 Then
                            isValid = True
                        Else
                            isValid = False
                        End If
                    End If
                Case 3
                    If day >= 1 And day <= 31 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 4
                    If day >= 1 And day <= 30 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 5
                    If day >= 1 And day <= 31 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 6
                    If day >= 1 And day <= 30 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 7
                    If day >= 1 And day <= 31 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 8
                    If day >= 1 And day <= 31 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 9
                    If day >= 1 And day <= 30 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 10
                    If day >= 1 And day <= 31 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 11
                    If day >= 1 And day <= 30 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
                Case 12
                    If day >= 1 And day <= 31 Then
                        isValid = True
                    Else
                        isValid = False
                    End If
            End Select
        Else
            isValid = False
        End If

        Return isValid

    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        setWarningIconPadding(errorCountry, cbxCountry, 8)
        setWarningIconPadding(errorName, txtName, 8)
        setWarningIconPadding(errorContact, txtContact, 8)
        setWarningIconPadding(errorEmail, txtEmail, 8)
        setWarningIconPadding(errorIC, txtICBack, 8)
        setWarningIconPadding(errorPassport, txtPassport, 8)
        setWarningIconPadding(errorDOB, dateDOB, 8)

        If (errorIC.GetError(txtICBack) = "Success" Or errorPassport.GetError(txtPassport) = "Success") And errorContact.GetError(txtContact) = "Success" And errorName.GetError(txtName) = "Success" And errorEmail.GetError(txtEmail) = "Success" And errorCountry.GetError(cbxCountry) = "Success" And errorDOB.GetError(dateDOB) = "Success" And errorContact.GetError(txtContact) = "Success" Then
            panelRegistration2.Visible = True
            panelRegistration1.Visible = False
        Else
            MessageBox.Show("Please complete the form before proceed")
        End If

        validateCountry()
        validateAge()
        validateEmail()
        validateName()

        'validate prefix in combobox,
        If validatePrefixContact() Then
            'validate conect number
            validateContact()
        Else
            setErrorMsg(errorContact, txtContact, "Please Select a prefix")
        End If

        'check for either ic chkbox is selected or passport chkbox is selected
        If chkbxIC.Checked Then
            validateIC()
        ElseIf chkbxPassport.Checked Then
            validatePassport()
        ElseIf Not (chkbxPassport.Checked And chkbxIC.Checked) Then
            setErrorMsg(errorPassport, txtPassport, "Please select either Passport or IC to fill in")
            setErrorMsg(errorIC, txtICBack, "Please select either Passport or IC to fill in")
        End If
    End Sub

    Private Sub validateName()
        errorName.SetIconPadding(txtName, 8)

        If checkNullField(txtName) Then
            For Each c As Char In txtName.Text
                If IsNumeric(c) Then
                    setErrorMsg(errorName, txtName, "No number Is allowed")
                    Exit For
                Else
                    setSuccessMsg(errorName, txtName, "Success")
                End If
            Next
        Else
            setErrorMsg(errorName, txtName, "Please fill In your name")
        End If
    End Sub

    'validate email'
    Private Sub validateEmail()
        setWarningIconPadding(errorEmail, txtEmail, 8)

        'Dim emailExpression As New Regex("^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3} \ .[0-9]{1, 3} \ .[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        If checkNullField(txtEmail) Then
            'format 1: first alphabet must be upper case behind @ (@Example) 2: first alphabet must be lower case behind @ (@example) 3: can consist - between letter behind @ 4. 
            If (txtEmail.Text.Trim Like "*@[A-Z]*.*" Or txtEmail.Text.Trim Like "*@[a-z]*.*" Or txtEmail.Text.Trim Like "*@[0-9]*.*" Or txtEmail.Text.Trim Like "*@[a-z]*-[a-z]*.*") And Not txtEmail.Text.Trim Like "@*.*" Then
                setSuccessMsg(errorEmail, txtEmail, "Success")
            Else
                setErrorMsg(errorEmail, txtEmail, "Invalid email")
            End If
        Else
            setErrorMsg(errorEmail, txtEmail, "Please fill in your email address")
        End If
    End Sub
    Private Function validatePrefixContact() As Boolean
        If cbxPrefixContact.SelectedIndex >= 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub validateContact()
        If checkNullField(txtContact) Then
            txtContact.Text = txtContact.Text.Trim()
            If txtContact.Text.Length >= 2 Then
                If txtContact.Text(1) = "1" Then
                    If txtContact.Text Like "##-########" Then
                        setSuccessMsg(errorContact, txtContact, "Success")
                    Else
                        setErrorMsg(errorContact, txtContact, "Invalid phone number")
                    End If
                ElseIf txtContact.Text(1) <> "1" Then
                    If txtContact.Text Like "##-#######" Then
                        setSuccessMsg(errorContact, txtContact, "Success")
                    Else
                        setErrorMsg(errorContact, txtContact, "Invalid phone number")
                    End If
                End If
            Else
                setErrorMsg(errorContact, txtContact, "Invalid phone number")
            End If
        Else
            setErrorMsg(errorContact, txtContact, "Please fill In your contact number")
        End If
    End Sub

    Private Sub validateAge()
        Dim d1 As Date = Date.Now
        setWarningIconPadding(errorDOB, dateDOB, 8)

        If Not (d1.Year - dateDOB.Value.Year >= 18 And d1.Year - dateDOB.Value.Year <= 75) Then
            setErrorMsg(errorDOB, dateDOB, "Age must between 18 and 75")
        Else
            setSuccessMsg(errorDOB, dateDOB, "Success")
        End If
    End Sub

    Private Sub validatePassport()
        setWarningIconPadding(errorPassport, txtPassport, 8)

        If checkNullField(txtPassport) Then
            If txtPassport.Text Like "[A-Z]########" Then
                setSuccessMsg(errorPassport, txtPassport, "Success")
                validateAge()
            Else
                setErrorMsg(errorPassport, txtPassport, "Invalid passport No")
            End If
        Else
            setErrorMsg(errorPassport, txtPassport, "Please fill in your passport ID")
        End If
    End Sub
    Private Sub setErrorMsg(e As ErrorProvider, control As Control, msg As String)
        e.SetError(control, msg)
        e.Icon = New Icon("C:\Users\Asus\Documents\Visual Studio 2022\Project\WindowsApp2\icon\sign_cancel.ico")
    End Sub

    Private Sub setSuccessMsg(e As ErrorProvider, control As Control, msg As String)
        e.SetError(control, msg)
        e.Icon = New Icon("C:\Users\Asus\Documents\Visual Studio 2022\Project\WindowsApp2\icon\sign_tick.ico")
    End Sub
    Private Sub setWarningIconPadding(e As ErrorProvider, control As Control, padding As Integer)
        e.SetIconPadding(control, padding)
    End Sub
    Private Function checkNullField(txtBox As TextBox) As Boolean
        If txtBox.Text.Trim.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function checkLength(txtBox As TextBox, length As Integer)
        If txtBox.Text.Trim.Length = length Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        Application.Exit()
    End Sub



    'Dragable Form
    Private Sub formTop_MouseDown(sender As Object, e As MouseEventArgs) Handles formTop.MouseDown
        If e.Button = MouseButtons.Left Then
            moveForm = True
            Me.Cursor = Cursors.Default
            moveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub formTop_MouseMove(sender As Object, e As MouseEventArgs) Handles formTop.MouseMove
        If moveForm Then
            Me.Location = Me.Location + (e.Location - moveForm_MousePosition)
        End If
    End Sub
    Private Sub formTop_MouseUp(sender As Object, e As MouseEventArgs) Handles formTop.MouseUp
        If e.Button = MouseButtons.Left Then
            moveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged
        validateState()
        cbxCity.Items.Clear()
        If cbxState.SelectedIndex >= 0 Then
            If cbxState.SelectedItem.Equals("Selangor") Then
                cbxCity.Items.AddRange(city(0))
            ElseIf cbxState.SelectedItem.Equals("Kuala Lumpur") Then
                cbxCity.Items.AddRange(city(1))
            ElseIf cbxState.SelectedItem.Equals("Terengganu") Then
                cbxCity.Items.AddRange(city(2))
            ElseIf cbxState.SelectedItem.Equals("Sarawak") Then
                cbxCity.Items.AddRange(city(3))
            ElseIf cbxState.SelectedItem.Equals("Sabah") Then
                cbxCity.Items.AddRange(city(4))
            ElseIf cbxState.SelectedItem.Equals("Penang") Then
                cbxCity.Items.AddRange(city(5))
            ElseIf cbxState.SelectedItem.Equals("Perlis") Then
                cbxCity.Items.AddRange(city(6))
            ElseIf cbxState.SelectedItem.Equals("Perak") Then
                cbxCity.Items.AddRange(city(7))
            ElseIf cbxState.SelectedItem.Equals("Pahang") Then
                cbxCity.Items.AddRange(city(8))
            ElseIf cbxState.SelectedItem.Equals("Negeri Sembilan") Then
                cbxCity.Items.AddRange(city(9))
            ElseIf cbxState.SelectedItem.Equals("Malacca") Then
                cbxCity.Items.AddRange(city(10))
            ElseIf cbxState.SelectedItem.Equals("Kelantan") Then
                cbxCity.Items.AddRange(city(11))
            ElseIf cbxState.SelectedItem.Equals("Kedah") Then
                cbxCity.Items.AddRange(city(12))
            ElseIf cbxState.SelectedItem.Equals("Johor") Then
                cbxCity.Items.AddRange(city(13))
            End If
        End If
        validatePostcode()
    End Sub

    Private Sub validateState()
        setWarningIconPadding(errorState, cbxState, 8)
        If cbxState.SelectedIndex >= 0 Then
            setSuccessMsg(errorState, cbxState, "Success")
        Else
            setErrorMsg(errorState, cbxState, "Please select a state")
        End If
    End Sub

    Private Sub txtPostcode_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPostcode.Validating
        validatePostcode()
    End Sub

    Private Sub validatePostcode()

        setWarningIconPadding(errorPostcode, txtPostcode, 8)

        If cbxState.SelectedIndex >= 0 Then
            Dim state As String = cbxState.SelectedItem()
            If cbxCity.SelectedIndex >= 0 Then
                Dim city As String = cbxCity.SelectedItem()
                If txtPostcode.Text.Length > 0 Then
                    If txtPostcode.Text.Length = 5 Then
                        'selangor postcode
                        If state.Equals("Selangor") Then
                            If (Integer.Parse(txtPostcode.Text) >= 40000 And Integer.Parse(txtPostcode.Text) <= 48300) Or (Integer.Parse(txtPostcode.Text) >= 63000 And Integer.Parse(txtPostcode.Text) <= 68100) Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'kl postcode
                        ElseIf state.Equals("Kuala Lumpur") Then
                            If (Integer.Parse(txtPostcode.Text.Trim) >= 50000 And Integer.Parse(txtPostcode.Text.Trim) <= 60000) Or txtPostcode.Text.Trim.Equals("68000") Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'terengganu postcode
                        ElseIf state.Equals("Terengganu") Then
                            If Integer.Parse(txtPostcode.Text.Trim) >= 20000 And Integer.Parse(txtPostcode.Text.Trim) <= 24300 Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'sarawak postcode
                        ElseIf state.Equals("Sarawak") Then
                            If Integer.Parse(txtPostcode.Text.Trim) >= 93000 And Integer.Parse(txtPostcode.Text.Trim) <= 98859 Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'sabah postcode
                        ElseIf state.Equals("Sabah") Then
                            If Integer.Parse(txtPostcode.Text.Trim) >= 88000 And Integer.Parse(txtPostcode.Text.Trim) <= 91309 Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'penang postcode
                        ElseIf state.Equals("Penang") Then
                            If Integer.Parse(txtPostcode.Text.Trim) >= 10000 And Integer.Parse(txtPostcode.Text.Trim) <= 14400 Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'perlis postcode
                        ElseIf state.Equals("Perlis") Then
                            If txtPostcode.Text Like "01###" Or txtPostcode.Text Like "02###" Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'perak postcode
                        ElseIf state.Equals("Perak") Then
                            If Integer.Parse(txtPostcode.Text.Trim) >= 30000 And Integer.Parse(txtPostcode.Text.Trim) <= 36810 Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'pahang postcode
                        ElseIf state.Equals("Pahang") Then
                            If cbxCity.SelectedItem.Equals("Genting Highlands") Then
                                If txtPostcode.Text.Equals("69000") Then
                                    setSuccessMsg(errorPostcode, txtPostcode, "Success")
                                Else
                                    setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                                End If
                            ElseIf cbxCity.SelectedItem.Equals("Bukit Fraser") Then
                                If txtPostcode.Text = "49000" Then
                                    setSuccessMsg(errorPostcode, txtPostcode, "Success")
                                Else
                                    setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                                End If
                            ElseIf cbxCity.SelectedItem.Equals("Cameron Highlands") Then
                                If Integer.Parse(txtPostcode.Text) >= 39000 And Integer.Parse(txtPostcode.Text) <= 39200 Then
                                    setSuccessMsg(errorPostcode, txtPostcode, "Success")
                                Else
                                    setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                                End If
                            Else
                                If (Integer.Parse(txtPostcode.Text.Trim) >= 25000 And Integer.Parse(txtPostcode.Text.Trim) <= 28800) Then
                                    setSuccessMsg(errorPostcode, txtPostcode, "Success")
                                Else
                                    setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                                End If
                            End If
                            'negeri sembilan postcode
                        ElseIf state.Equals("Negeri Sembilan") Then
                            If (Integer.Parse(txtPostcode.Text.Trim) >= 70000 And Integer.Parse(txtPostcode.Text.Trim) <= 73509) Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'malacca postcode
                        ElseIf state.Equals("Malacca") Then
                            If (Integer.Parse(txtPostcode.Text.Trim) >= 75000 And Integer.Parse(txtPostcode.Text.Trim) <= 78309) Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'kelantan postcode
                        ElseIf state.Equals("Kelantan") Then
                            If (Integer.Parse(txtPostcode.Text.Trim) >= 15000 And Integer.Parse(txtPostcode.Text.Trim) <= 18500) Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'johor postcode
                        ElseIf state.Equals("Johor") Then
                            If (Integer.Parse(txtPostcode.Text.Trim) >= 79000 And Integer.Parse(txtPostcode.Text.Trim) <= 86900) Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                            'kedah postcode
                        ElseIf state.Equals("Kedah") Then
                            If txtPostcode.Text Like "05###" Or txtPostcode.Text Like "06###" Or txtPostcode.Text Like "07###" Or txtPostcode.Text Like "08###" Or txtPostcode.Text Like "091##" Or txtPostcode.Text Like "092##" Or txtPostcode.Text Like "093##" Or txtPostcode.Text Like "094##" Or txtPostcode.Text Like "095##" Or txtPostcode.Text Like "096##" Or txtPostcode.Text Like "097##" Or txtPostcode.Text Like "098##" Then
                                setSuccessMsg(errorPostcode, txtPostcode, "Success")
                            Else
                                setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode")
                            End If
                        Else
                            setErrorMsg(errorPostcode, txtPostcode, "Please select a state")
                        End If
                    Else
                        setErrorMsg(errorPostcode, txtPostcode, "Invalid postcode length")
                    End If
                Else
                    setErrorMsg(errorPostcode, txtPostcode, "Please fill in your postcode")
                End If
            Else
                setErrorMsg(errorPostcode, txtPostcode, "Please select your city")
            End If
        Else
            setErrorMsg(errorPostcode, txtPostcode, "Please select your state")
        End If
    End Sub

    Private Sub cbxCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCity.SelectedIndexChanged
        validateCity()
    End Sub
    Private Sub validateCity()
        setWarningIconPadding(errorCity, cbxCity, 8)
        If cbxCity.SelectedIndex >= 0 Then
            setSuccessMsg(errorCity, cbxCity, "Success")
        Else
            setErrorMsg(errorCity, cbxCity, "Please select a state")
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) |*.jpg; *.jpeg; *.png"
        Dim i As Integer = OpenFileDialog1.FileName.Length - 1
        'Dim text As String = ""

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'While i >= 0
            '    If OpenFileDialog1.FileName(i) <> "\" Then
            '        text &= OpenFileDialog1.FileName(i)
            '        i = i - 1
            '    Else
            '        Exit While
            '    End If
            'End While

            picBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            lblFileResult.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub txtHome_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHome.Validating
        validateHomeAddress()
    End Sub
    Private Sub validateHomeAddress()

        setWarningIconPadding(errorHome, txtHome, 8)

        If checkNullField(txtHome) Then
            If txtHome.Text Like "*,[Jalan]*,[Taman]*" Then
                setSuccessMsg(errorHome, txtHome, "Success")
            Else
                setErrorMsg(errorHome, txtHome, "Invalid address")
            End If
        Else
            setErrorMsg(errorHome, txtHome, "Please fill in your address")
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        validateHomeAddress()
        validateState()
        validateCity()
        validatePostcode()
        validatecbxProgramme()
        validateFile()

        If errorHome.GetError(txtHome) = "Success" And errorCity.GetError(cbxCity) = "Success" And errorPostcode.GetError(txtPostcode) = "Success" And errorState.GetError(cbxState) = "Success" And errorProgramme.GetError(cbxProgramme) = "Success" And errorResult.GetError(btnUpload) = "Success" Then
            If isVerified Then
                Try
                    conn.Open()
                    sql = "INSERT INTO Application(applicantName,ICNo,passportNo,country,contactNo,gender,dateOfBirth,emailAddress,homeAddress,state,city,postcode,programme,result) VALUES 
(@name,@icNo,@passportNo,@country,@contactNo,@gender,@DOB,@emailAddress,@homeAddress,@state,@city,@postcode,@programme,@result)"
                    command = New MySqlCommand(sql, conn)
                    command.Parameters.AddWithValue("@name", txtName.Text)
                    command.Parameters.AddWithValue("@icNo", txtICFront.Text.Trim & txtICMiddle.Text.Trim & txtICBack.Text.Trim)
                    command.Parameters.AddWithValue("@passportNo", txtPassport.Text)
                    command.Parameters.AddWithValue("@country", cbxCountry.SelectedItem)
                    command.Parameters.AddWithValue("@contactNo", "60" & txtContact.Text)
                    If rBtnFemale.Checked Then
                        command.Parameters.AddWithValue("@gender", "F")
                    ElseIf rBtnMale.Checked Then
                        command.Parameters.AddWithValue("@gender", "M")
                    End If

                    command.Parameters.AddWithValue("@DOB", dateDOB.Value.Year & "-" & dateDOB.Value.Month & "-" & dateDOB.Value.Day)
                    command.Parameters.AddWithValue("@emailAddress", txtEmail.Text)
                    command.Parameters.AddWithValue("@homeAddress", txtHome.Text)
                    command.Parameters.AddWithValue("@state", cbxState.SelectedItem)
                    command.Parameters.AddWithValue("@city", cbxCity.SelectedItem)
                    command.Parameters.AddWithValue("@postcode", txtPostcode.Text)
                    Dim conn1 As MySqlConnection = New MySqlConnection("server=localhost;database=SIS;userid=root;password=root")
                    Try
                        conn1.Open()
                        Dim sql1 As String = "SELECT programmeID FROM Programme WHERE programmeName = @programmeName"
                        Dim command1 As New MySqlCommand(sql1, conn1)
                        command1.Parameters.AddWithValue("@programmeName", cbxProgramme.SelectedItem)
                        reader = command1.ExecuteReader()
                        While reader.Read
                            command.Parameters.AddWithValue("@programme", reader.GetString("programmeID"))
                        End While
                        reader.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message())
                    Finally
                        conn1.Close()
                    End Try
                    Dim ms As New MemoryStream
                    picBox.Image.Save(ms, picBox.Image.RawFormat)
                    Dim img As Byte()
                    img = ms.ToArray()
                    command.Parameters.AddWithValue("@result", img)

                    command.ExecuteNonQuery()

                    MessageBox.Show("Record has been submitted")

                    resetForm()

                    panelRegistration1.Visible = True
                    panelRegistration2.Visible = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                Finally
                    conn.Close()
                End Try
            Else
                verifyForm.Show()
            End If
        Else
            MessageBox.Show("Please complete the form")
        End If

    End Sub

    Private Sub resetForm()
        cbxCity.SelectedIndex = -1
        txtPostcode.Text = ""
        txtName.Text = ""
        cbxCountry.SelectedIndex = -1
        cbxPrefixContact.SelectedIndex = -1
        txtContact.Text = ""
        txtEmail.Text = ""
        txtHome.Text = ""
        cbxState.SelectedIndex = -1

        txtICBack.Text = ""
        txtICMiddle.Text = ""
        txtICFront.Text = ""
        txtPassport.Text = ""
        chkbxIC.Checked = False
        chkbxIC.Enabled = True
        chkbxPassport.Checked = False
        chkbxPassport.Enabled = True
        txtPassport.BackColor = Color.Silver
        txtPassport.Enabled = False
        txtICBack.Enabled = False
        txtICBack.BackColor = Color.Silver
        txtICMiddle.Enabled = False
        txtICMiddle.BackColor = Color.Silver
        txtICFront.Enabled = False
        txtICFront.BackColor = Color.Silver

        cbxProgramme.SelectedIndex = -1
        lblFileResult.Text = ""
        OpenFileDialog1.FileName = Nothing

        errorProgramme.Dispose()
        errorName.Dispose()
        errorDOB.Dispose()
        errorIC.Dispose()
        errorPassport.Dispose()
        errorCountry.Dispose()
        errorEmail.Dispose()
        errorContact.Dispose()
        errorCity.Dispose()
        errorHome.Dispose()
        errorState.Dispose()
        errorPostcode.Dispose()
        errorResult.Dispose()
        errorProgramme.Dispose()

        chkBxICIsChecked()
        chkBxPassIsChecked()
        isVerified = False

    End Sub
    Private Sub chkBxICIsChecked()
        If chkbxIC.Checked Then
            chkbxPassport.Checked = False
            chkbxIC.Enabled = False
            chkbxPassport.Enabled = True
            txtPassport.Enabled = False
            'disable passport field when ic is checked
            txtPassport.BackColor = Color.Silver
            'enable ic field
            txtICFront.Enabled = True
            txtICFront.BackColor = Color.White
            txtICMiddle.Enabled = True
            txtICMiddle.BackColor = Color.White
            txtICBack.Enabled = True
            txtICBack.BackColor = Color.White
            txtPassport.Text = ""
            txtICFront.Text = ""
            txtICMiddle.Text = ""
            txtICBack.Text = ""
            errorPassport.Dispose()
            cbxCountry.SelectedItem = "Malaysia"
        End If
    End Sub
    Private Sub chkBxPassIsChecked()
        If chkbxPassport.Checked Then
            chkbxIC.Checked = False
            chkbxPassport.Enabled = False
            chkbxIC.Enabled = True
            'disable ic field when passport is checked
            txtICBack.Enabled = False
            txtICBack.BackColor = Color.Silver
            txtICMiddle.Enabled = False
            txtICMiddle.BackColor = Color.Silver
            txtICFront.Enabled = False
            txtICFront.BackColor = Color.Silver
            'enable passport field
            txtPassport.Enabled = True
            txtPassport.BackColor = Color.White
            txtPassport.Text = ""
            txtICFront.Text = ""
            txtICMiddle.Text = ""
            txtICBack.Text = ""
            errorIC.Dispose()
            cbxCountry.SelectedIndex = -1
        End If
    End Sub

    Private Sub cbxProgramme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProgramme.SelectedIndexChanged
        validatecbxProgramme()
    End Sub

    Private Sub validatecbxProgramme()
        setWarningIconPadding(errorProgramme, cbxProgramme, 8)
        If cbxProgramme.SelectedIndex >= 0 Then
            setSuccessMsg(errorProgramme, cbxProgramme, "Success")
        Else
            setErrorMsg(errorProgramme, cbxProgramme, "Please select a programme")
        End If
    End Sub

    Private Sub lblFileResult_TextChanged(sender As Object, e As EventArgs) Handles lblFileResult.TextChanged
        validateFile()
    End Sub
    Private Sub validateFile()
        setWarningIconPadding(errorResult, btnUpload, 8)
        If lblFileResult.Text.Length > 0 Then
            setSuccessMsg(errorResult, btnUpload, "Success")
        Else
            setErrorMsg(errorResult, btnUpload, "Please upload your result")
        End If
    End Sub

    Private Sub RegistrationForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim loginPage As New login()
        loginPage.Show()
        loginPage.clear()
        resetForm()
        Me.Hide()
        panelRegistration1.Visible = True
        panelRegistration2.Visible = False
    End Sub

End Class

Class CustomException : Inherits Exception

    Public Sub New(msg As String)
        MyBase.New(msg)
    End Sub
End Class