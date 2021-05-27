// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).on("click", "button.button.like", function () {
    var post_id = parseInt($(this).find(".post-id-value").val());
    var curr_form = $(this).parent("form");
    var likes_number_el = $(this).parent("form").parent("div").find(".like-comment-repost-number")[0];

    $.ajax({
        url: '/Users/LikeOrDeleteLike/' + post_id.toString(),
        type: "POST",
        data: { postId: post_id },
        dataType: "json",
        success: function (response) {
            $(curr_form).empty();
            if (response.like) {
                $(curr_form).append('<button type="submit" class="button like" >' +
                    '<input id="post-id-value" type="text" name="postId" value="@post.Id" style="display: none" />' +
                    '<svg xmlns="http://www.w3.org/2000/svg" width="26" height="26" fill="violet" class="bi bi-heart-fill" viewBox="0 0 16 16">' +
                    '<path fill-rule="evenodd" d="M8 1.314C12.438-3.248 23.534 4.735 8 15-7.534 4.736 3.562-3.248 8 1.314z" />' +
                    '</svg>' +

                    '</button>');
            }

            else {
                $(curr_form).append('<button type="submit" class="button like">' +
                    '<input id="post-id-value" type="text" name="postId" value="@post.Id" style="display: none" />' +
                    '<svg xmlns="http://www.w3.org/2000/svg" width="26" height="26" fill="currentColor" class="bi bi-heart" viewBox="0 0 16 16">' +
                    '<path d="m8 2.748-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z" />' +
                    '</svg>' +

                    '</button>');
            }
            $(likes_number_el).empty();
            $(likes_number_el).append(response.likes_number.toString());
        },
    });
});