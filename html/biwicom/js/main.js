
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
function load_form_forget(){
	document.getElementById("form-login").style.display = "none";
	document.getElementById("forger-pw").style.display = "block";
}
function return_form_login(){
	document.getElementById("forger-pw").style.display = "none";
	document.getElementById("form-login").style.display = "block";
}
function load_menu_mobile(){
	document.getElementById("header-menu-mobile").style.display = "block";
}
function close_menu_mobile(){
	document.getElementById("header-menu-mobile").style.display = "none"; 
}
function load_user_mobile(){
	document.getElementById("header-user-mobile").style.display = "block";
}
function close_user_mobile(){
	document.getElementById("header-user-mobile").style.display = "none";
}