/*BLOG TYPES*/

function PopulateBlogTypesDeleteList() {
    $.ajax({
        url: '/api/BlogTypes/GetBlogTypes',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            $("#BlogTypesDeleteList").empty();
            for (var i = 0; i < data.length; i++) {
                $("#BlogTypesDeleteList").append('<li id="BlogType' + data[i].Id + '" class="list-group-item d-flex justify-content-between align-items-center">' + data[i].Name + '<span class="deleteBlogTypeButton" data-deleteblogtypeid = ' + data[i].Id + '><i class="fa fa-trash-o" aria-hidden="true"></i></span></li>');
            }
        },
        error: function (xhr, status) {
            alert(status);
        }
    });
}
function PopulateBlogTypesDropdownList() {
    $.ajax({
        url: '/api/BlogTypes/GetBlogTypes',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            $("#BlogTypeId").empty();
            var isSelected = "";
            for (var i = 0; i < data.length; i++) {
                if (i === data.length - 1) {
                    isSelected = "selected";
                }
                $("#BlogTypeId").append('<option ' + isSelected + ' value="' + data[i].Id + '">' + data[i].Name + '</option>');
            }
        },
        error: function (xhr, status) {
            alert(status);
        }
    });
}
$(document).on('click', '.deleteBlogTypeButton', function () {
    blogTypeId = $(this).data("deleteblogtypeid");
    $.ajax({
        type: "post",
        url: "/api/BlogTypes/DeleteBlogType/" + blogTypeId
    }).done(function () {
        var BlogTypesContToRemove = $("#BlogType" + blogTypeId);
        BlogTypesContToRemove.remove();
        PopulateBlogTypesDropdownList();
        toastr.success("Blog type deleted.");
    }).fail(function () {
        toastr.error("Error! Blog type is not deleted.");
    });
});
function SaveNewBlogType() {
    if ($('#newBlogTypeName').val() === '') {
        toastr.error("Please enter blog type name.");
        $('#newBlogTypeName').focus();
    }
    else {
        var NewBlogType = new Object();
        NewBlogType.Name = $('#newBlogTypeName').val();
        $.ajax({
            url: '/api/BlogTypes/AddNewBlogType',
            type: 'POST',
            dataType: 'json',
            data: NewBlogType,
            success: function () {
                toastr.success("Blog type added.");
                $('#newBlogTypeName').val('');
                PopulateBlogTypesDeleteList();
                PopulateBlogTypesDropdownList();
                $('#PropertyTypeId').select2('destroy');
                $('#PropertyTypeId').select2();
            },
            error: function () {
                toastr.error("Error! Blog type is not added.");
            }
        });
    }
}
window.onload = function () {
    PopulateBlogTypesDeleteList();
};

/*BLOG TYPES*/

document.getElementById("BlogImageInput").onchange = function () {
    var reader = new FileReader();

    reader.onload = function (e) {
        // get loaded data and render thumbnail.
        document.getElementById("preview-image-blog").src = e.target.result;
    };

    // read the image file as a data URL.
    reader.readAsDataURL(this.files[0]);
};

$(document).ready(function () {
    $(".blog-content-textarea").summernote({
        height: 600,
        minHeight: null,
        callbacks: {
            onImageUpload: function (files, editor, welEditable) {

                for (var i = files.length - 1; i >= 0; i--) {
                    sendFile(files[i], this);
                }
            }
        }
    });
});
function sendFile(file, el) {
    var form_data = new FormData();
    form_data.append('file', file);
    $.ajax({
        data: form_data,
        type: "POST",
        url: '@Url.Action("UploadImage", "BlogManager", new { area = "Admin" })',
        cache: false,
        contentType: false,
        processData: false,
        success: function (url) {
            $(el).summernote('editor.insertImage', url);
        }
    });
}