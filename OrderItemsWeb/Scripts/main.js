$(document).ready(function () {
})

function checkNumber(e, id) {
	if (e.which < 48 || e.which > 57) {
		$(`#error-message-${id}`).html("Please enter number!").show().fadeOut(3000);
		return false;
	}

	return true
}