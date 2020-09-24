$(document).ready(function () {
    $('.page-loader').hide();
    $(".WebsiteEditorArea").summernote({
        minHeight: null,
        toolbar: [
            ['style', ['bold', 'italic', 'underline', 'clear']],
            ['undo', ['undo']],
            ['insert', ['link']]
        ]
    });
    $('.note-editable').focus(function () {
        $(this).siblings('.note-toolbar').show();
    });
    $('.note-editable').blur(function () {
        $(this).siblings('.note-toolbar').hide();
    });
    $("input[type=file]").change(function () {
        var inputName = $(this).attr('id');
        var imageName = inputName + "Image";

        var reader = new FileReader();

        reader.onload = function (e) {
            // get loaded data and render thumbnail.
            document.getElementById(imageName).src = e.target.result;
        };

        reader.readAsDataURL(this.files[0]);
    });
});