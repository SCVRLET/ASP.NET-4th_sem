﻿$('.button.comment').on('click', function () {
    var el = $(this).parent("div").parent("div").find(".reply-form")[0]
    el.style.display = "flex"
});

$('textarea').on('input', function () {
    this.style.height = 'auto';

    if (this.scrollHeight < 220) {
        this.style.height =
            (this.scrollHeight) + 'px';
    }
    else {
        this.style.height =
            220 + 'px';
    }
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            var image = document.createElement('img');
            image.id = "post-photo-preview";
            var photos_block = document.getElementById("post-photos");
            photos_block.appendChild(image);


            $('#post-photo-preview').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}


$("#add-photo-field").change(function () {
    readURL(this);
});


$(document).ready(function () {
    $('#push_btn').click(function () {

        var d = $('#make-post-button').serializeArray();
        var value = $("#autoresizing").val();

        $.ajax({
            url: '/ajax',
            data: {
                'd': d,
                'rich': value
            },
            dataType: 'json',
            success: function (data) {
                if (data.is_taken) {
                    var pathname = window.location.pathname;
                    if (pathname === '/main/') {
                        location.reload()
                    }
                } else {
                    console.log('Что-то пошло не так :(');
                    //    alert not full data
                }
            }

        });
    });
});

$(document).on("click", ".delete-post-button", function () {
    var post_id = parseInt($(this).find(".post-delete-id").val());
    console.log(post_id);
    $.ajax({
        url: '/Users/DeletePost/' + post_id.toString(),
        type: "POST",
        data: { postId: post_id },
        dataType: "json",
        success: function (response) {
            $("#posts-container").empty();
            for (var post in response.profile_posts) {
                $("#posts-container").append(
                    '<div class="post">' +
                    '<div class="post-header">' +

                    '<div class="post-info">' +
                    '<div class="postmaker-avatar">' +
                    '@if (Model.User.Avatar == null)' +
                    '{' +
                    '<img src="~/images/default_avatar/icon.png" class="postmaker-img">' +
                    '}' +
                    ' else' +
                    ' {' +
                                                '<img class="postmaker-img" />' +
                                                '}' +

                                                '</div>' +
                                                '<div class="postmaker-login-and-date" style="color:white">' +
                                                '<a style="color:rgb(111, 178, 255)" href="#">' +
                                                '@Model.User.UserName' +
                    '</a>'+
                                            '<br><small>@post.CreatedAt</small>' +
                    '</div>' +
                                        '</div>' +
                    '@if (User.Identity.Name == Model.User.UserName)' +
                    '{' +
                    '<div class="edit-post">' +
                    'form method="POST" asp-action="DeletePost" asp-controller="Users">' +
                    '<input class="post-delete-id" type="text" value="@post.Id" name="postId" style="display: none" />' +
                    '<button type="submit" class="delete-post-button">' +
                    '<svg title="Delete post" xmlns="http://www.w3.org/2000/svg" width="20" height="24" fill="currentColor" class="bi bi-x" viewBox="0 0 16 16">' +
                    '<path d="M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z" />' +
                                                    '</svg>' +
                    '</button>' +
                    '</form>' +
                    ' </div>' +
                    '   }' +

                    '</div>' +
                    '<div class="post-text" style="color:white">' +
                    ' @post.Text' +
                    '</div>' +
                    '<div class="like-comment-repost">' +
                    '<form method="post" class="like-post-form">' +
                    ' @if (post.Likes.Where(x => x.UserId == userManager.FindByNameAsync(User.Identity.Name).Result.Id).Count() > 0)' +
                    '{' +
                    '<button type="submit" class="button like" >' +
                    '<input class="post-id-value" type="text" name="postId" value="@post.Id" style="display: none" />' +
                    ' <svg xmlns="http://www.w3.org/2000/svg" width="26" height="26" fill="violet" class="bi bi-heart-fill" viewBox="0 0 16 16">' +
                    '    <path fill-rule="evenodd" d="M8 1.314C12.438-3.248 23.534 4.735 8 15-7.534 4.736 3.562-3.248 8 1.314z" />' +
                    '  </svg>' +
                                              
                    ' </button>' +
                    '}' +

                    'else' +
                    '{' +
                    '<button type="submit" class="button like">' +
                    '<input class="post-id-value" type="text" name="postId" value="@post.Id" style="display: none" />' +
                    '<svg xmlns="http://www.w3.org/2000/svg" width="26" height="26" fill="currentColor" class="bi bi-heart" viewBox="0 0 16 16">' +
                    '<path d="m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z" />' +
                    '</svg>' +

                    '</button>' +
                    '}' +
                    '</form>' +
                    '@if (post.Likes != null)' +
                    '@if (post.Likes.Count() > 0)' +
                    '{' +
                    '<div class="like-comment-repost-number">@post.Likes.Count</div>' +
                    '}' +
                    '<div class="button comment">' +
                    '<svg xmlns="http://www.w3.org/2000/svg" width="26" height="26" fill="currentColor" class="bi bi-chat-square" viewBox="0 0 16 16">' +
                    '<path d="M14 1a1 1 0 0 1 1 1v8a1 1 0 0 1-1 1h-2.5a2 2 0 0 0-1.6.8L8 14.333 6.1 11.8a2 2 0 0 0-1.6-.8H2a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h12zM2 0a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2h2.5a1 1 0 0 1 .8.4l1.9 2.533a1 1 0 0 0 1.6 0l1.9-2.533a1 1 0 0 1 .8-.4H14a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z" />' +
                    '</svg>' +

                    '</div>' +
                    '<div class="button repost">' +
                    '<svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="currentColor" class="bi bi-reply" viewBox="0 0 16 16">' +
                    ' <path d="M6.598 5.013a.144.144 0 0 1 .202.134V6.3a.5.5 0 0 0 .5.5c.667 0 2.013.005 3.3.822.984.624 1.99 1.76 2.595 3.876-1.02-.983-2.185-1.516-3.205-1.799a8.74 8.74 0 0 0-1.921-.306 7.404 7.404 0 0 0-.798.008h-.013l-.005.001h-.001L7.3 9.9l-.05-.498a.5.5 0 0 0-.45.498v1.153c0 .108-.11.176-.202.134L2.614 8.254a.503.503 0 0 0-.042-.028.147.147 0 0 1 0-.252.499.499 0 0 0 .042-.028l3.984-2.933zM7.8 10.386c.068 0 .143.003.223.006.434.02 1.034.086 1.7.271 1.326.368 2.896 1.202 3.94 3.08a.5.5 0 0 0 .933-.305c-.464-3.71-1.886-5.662-3.46-6.66-1.245-.79-2.527-.942-3.336-.971v-.66a1.144 1.144 0 0 0-1.767-.96l-3.994 2.94a1.147 1.147 0 0 0 0 1.946l3.994 2.94a1.144 1.144 0 0 0 1.767-.96v-.667z" />' +
                    '</svg>' +
                    '</div>' +
                    '</div>' +
                    '<div class="reply-form">' +
                    '<div class="reply-maker-avatar">' +
                    ' @if (Model.User.Avatar == null)' +
                    '{' +
                    '<img class="reply-maker-img" src="~/images/default_avatar/icon.png">' +
                    ' }' +
                    'else' +
                    '{' +
                    '<img class="reply-maker-img" />' +
                    '}' +
                    '</div>' +
                    '<textarea></textarea>' +
                    '<div class="send-reply-button">' +
                    '<svg xmlns="http://www.w3.org/2000/svg" width="28" height="28" fill="currentColor" class="bi bi-arrow-right-circle" viewBox="0 0 16 16">' +
                    ' <path fill-rule="evenodd" d="M1 8a7 7 0 1 0 14 0A7 7 0 0 0 1 8zm15 0A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM4.5 7.5a.5.5 0 0 0 0 1h5.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3a.5.5 0 0 0 0-.708l-3-3a.5.5 0 1 0-.708.708L10.293 7.5H4.5z" />' +
                                                '</svg>' +
                    '</div>' +

                    '</div>' +
                                '</div>'
                )
            }
        },
    });
});