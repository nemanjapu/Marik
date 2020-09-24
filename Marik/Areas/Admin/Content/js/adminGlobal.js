jQuery.validator.setDefaults({
    // This will ignore all hidden elements alongside `contenteditable` elements
    // that have no `name` attribute
    ignore: ":hidden, [contenteditable='true']:not([name]),.note-editable.card-block"
});