$("#change-avatar-input").on("input", function () {
    var avatar = document.getElementById("change-avatar-input").files[0]

    $.ajax({
        url: '/Users/ChangeAvatar/',
        type: "POST",
        data: { avatar: avatar },
        dataType: "json",
        success: function (response) {
            if (response.result) {
            }

            else {
            }
        },
    });
});

function chooseAvatarImage() {
    document.getElementById("change-avatar-input").click()
}

function changeVariant(evt, el_id) {
    var prof = document.getElementById("profile-settings-variant");
    var security = document.getElementById("profile-security-settings-variant");

    if (el_id == "profile-settings-variant") {

        security.style.marginTop = "0.25em"
        security.style.color = "white"

        prof.style.marginTop = "0"
        prof.style.color = "mediumpurple"

        $("#settings-options").empty()

        $("#settings-options").append(
            '<div class="settings-option" id="change-profile-name-option">' +
            '<div class="settings-option-info">' +
            '<div class="settings-option-descr label">' +
            'Name' +
            ' </div>' +
            '<div class="settings-option-descr description">' +
            '@Model.FirstName' +
            '</div>' +
            '<div class="settings-option-descr right-control">' +
            '  <a tabindex="0" role="link">Change</a>' +
            '</div>' +
            '</div>' +
            '<div class="settings-change-block">' +

            ' </div>' +
            '</div>' +
            '<div class="settings-option">' +
            ' <div class="settings-option-info">' +
            '  <div class="settings-option-descr label">' +
            '      Surname' +
            ' </div>' +
            ' <div class="settings-option-descr description">' +
            '@Model.SecondName' +
            ' </div>' +
            '<div class="settings-option-descr right-control">' +
            '     <a tabindex="0" role="link">Change</a>' +
            ' </div>' +
            '</div>' +
            '<div class="settings-change-block">' +
            ' </div>' +
            '</div>' +
            '<input type="file" accept="image/x-png, image/png, image/gif, image/jpeg" id="change-avatar-input" hidden>' +
            '<div class="settings-option" id="change-avatar-option" onclick="chooseAvatarImage()">' +
            '  <div class="settings-option-info">' +
            '      <div class="settings-option-descr label">' +
            '         Avatar' +
            '     </div>' +
            '    <div class="settings-option-descr description">' +

            '  </div>' +
            ' <div class="settings-option-descr right-control">' +
            '    <a tabindex="0" role="link">Change</a>' +
            '  </div>' +
            ' </div>' +
            '<div class="settings-change-block">' +

            ' </div>' +
            '</div>'

        )
    }

    else {
        prof.style.marginTop = "0.25em"
        prof.style.color = "white"

        security.style.marginTop = "0"
        security.style.color = "mediumpurple"

        $("#settings-options").empty()
        $("#settings-options").append(
            '<div class="settings-option">' +
            '<div class="settings-option-info">' +
            '<div class="settings-option-descr label">' +
            'Email' +
            ' </div>' +
            '<div class="settings-option-descr description">' +
            '@Model.Email' +
            '</div>' +
            '<div class="settings-option-descr right-control">' +
            '  <a tabindex="0" role="link">Change</a>' +
            '</div>' +
            '</div>' +
            '<div class="settings-change-block">' +

            ' </div>' +
            '</div>' +
            '<div class="settings-option">' +
            '<div class="settings-option-info">' +
            '<div class="settings-option-descr label">' +
            'Password' +
            ' </div>' +
            '<div class="settings-option-descr description">' +
            ' ***********' +
            '</div>' +
            '<div class="settings-option-descr right-control">' +
            '  <a tabindex="0" role="link">Change</a>' +
            '</div>' +
            '</div>' +
            '<div class="settings-change-block">' +

            ' </div>' +
            '</div>'
        )
    }
}