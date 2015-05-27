function CreatDoctorsAppointment() {
    alert($("#name").val());

    jsonName = $("#name").val();
    $.post("/Home/PostbackTest", { Name: jsonName, AppointmentId: 1 }, function () { alert("wooooo"); });
}