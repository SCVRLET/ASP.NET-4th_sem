$('.button.comment').on('click', function () {
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


$(document).on("click", ".delete-post-button", function () {
    var post_id = parseInt($(this).find(".post-delete-id").val());
    console.log(post_id);
    $.ajax({
        url: '/Users/DeletePost/',
        type: "POST",
        data: { postId: post_id },
        dataType: "json",
        success: function (response) {
            var children = document.getElementById("posts-container").children

            for (i = 0; i < children.length; i++) {

                if (children[i].querySelectorAll('.post-id-value')[0].getAttribute("value") == post_id) {
                    children[i].remove();
                    break
                }
            }
        },
    });
});