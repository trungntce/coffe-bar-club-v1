
let checkDisplay = false;
function language_option(){
	if (checkDisplay) {
		document.getElementById("option-language").style.display = "none";
		checkDisplay = false;
	}
	else{
		document.getElementById("option-language").style.display = "block";
		checkDisplay = true;
	}
	
}
