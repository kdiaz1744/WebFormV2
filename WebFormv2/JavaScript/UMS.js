$(document).ready(function () {

    //I wrote this so I'm sure that it won't cause errors trying to run the script when 
    // I'm not using it
    var currentUrl = String(window.location.href);
    if (currentUrl === "https://localhost:44308/Views/AdminHome" || currentUrl === "https://localhost:44308/Views/AdminHome.aspx")
        GetAllUsers(currentUrl);
    else if (currentUrl === "https://localhost:44308/Views/RegularHome" || currentUrl === "https://localhost:44308/Views/RegularHome.aspx")
        ViewAllUser(currentUrl);

});


function GetAllUsers(currentUrl) {
    $.ajax({
        type: "POST",
        url: "AdminHome.aspx/GetAllUsers",
        //url: "Default.aspx/GetAllUsers",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            GenerateAdminTable(data.d);
            //alert("Worked");

        }, error: function (err) {
            alert("Failed to fetch data")
        }

    })
}

function GenerateAdminTable(AllUserData) {
    var getalluser = $("#AllUserTable").DataTable({
        data: AllUserData,
        responsive: true,
        columns: [
            {
                title: "Username",
                data: "UserName"
            },
            {
                title: "First Name",
                data: "FirstName"
            },
            {
                title: "Last Name",
                data: "LastName"
            },
            {
                title: "Email",
                data: "Email"
            },
            {
                title: "Role",
                data: "RoleID",
                render: function (data, type, full, meta) {
                    if (data === 1) { return "Admin"; }
                    return "User";
                }
            },
            {
                title: "Active",
                data: "StatusID",
                render: function (data, type, full, meta) {
                    if (data === 1) { return "Active"; }
                    return "Inactive";
                }
            },
            {
                data: "UserID",
                render: function (data, type, full, meta) {
                    var a = `<button id="btn" type="button" onclick="EditUser(${data})">View</button>`;
                    return a;
                }
            }
        ]
    })
}


function EditUser(id) {
    console.log(id);
    //Response.Redirect("EditUser.aspx?UserID=" + id);

    window.location.href = "https://localhost:44308/Views/EditUser.aspx?" + "UserID=" + id;
    //alert("Worked: " + id);
}


function ViewAllUser(currentUrl) {
    $.ajax({
        type: "POST",
        url: "RegularHome.aspx/ShowAllUsers",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            GenerateRegularTable(data.d);
            //alert("Worked");

        }, error: function (err) {
            alert("Failed to fetch data")
        }

    })
}

function GenerateRegularTable(AllUserData) {
    var getalluser = $("#AllUserTable").DataTable({
        data: AllUserData,
        responsive: true,
        columns: [
            {
                title: "Username",
                data: "UserName"
            },
            {
                title: "First Name",
                data: "FirstName"
            },
            {
                title: "Last Name",
                data: "LastName"
            },
            {
                title: "Email",
                data: "Email"
            },
            {
                data: "UserID",
                render: function (data, type, full, meta) {
                    var a = `<button id="btn" type="button" onclick="ViewUser(${data})">View</button>`;
                    return a;
                }
            }
        ]


    })
}

function ViewUser(id) {
    console.log(id);
    //Response.Redirect("EditUser.aspx?UserID=" + id);

    window.location.href = "https://localhost:44308/Views/ViewUser.aspx?" + "UserID=" + id;
    //alert("Worked: " + id);
}