﻿$(document).ready(function() {

    // Wire up all of the checkboxes to run markCompleted()
    $('.off-checkbox').on('click', function(e) {
        markCompleted(e.target);
    });
});
    
function markCompleted(checkbox) {
    checkbox.disabled = true;

    var row = checkbox.closest('tr');
    $(row).addClass('off');

    var form = checkbox.closest('form');
    form.submit();
}
