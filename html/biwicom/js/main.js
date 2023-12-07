
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
var check_form_branch = false;
function load_form_branch(){
	if (check_form_branch) {
		document.getElementById("form-branch").style.display = "none";
		check_form_branch = false;
	}
	else{
		document.getElementById("form-branch").style.display = "block";
		check_form_branch=true;
	}
	
}


function hiddenType(btnID,hiddenIDs){
	let btnToggle = document.getElementById(btnID);
	let ariaExpanded = btnToggle.getAttribute('aria-expanded');
	let hiddenID = document.getElementById(hiddenIDs);
	if(ariaExpanded === 'false'){
		hiddenID.classList.add('hidden');
		hiddenID.classList.remove('show');
		btnToggle.setAttribute('aria-expanded', 'true');
	}
	else{
		hiddenID.classList.add('show');
		hiddenID.classList.remove('hidden');
		btnToggle.setAttribute('aria-expanded', 'false');
	}
	
}




function tabContent(btnID,nameClass,tabID,tablink){;
	tabcontent = document.getElementsByClassName(nameClass);
  	for (i = 0; i < tabcontent.length; i++) {
    	tabcontent[i].style.display = "none";
  	}
  	tablinks = document.getElementsByClassName(tablink);
  	for (i = 0; i < tablinks.length; i++) {
    	tablinks[i].className = tablinks[i].className.replace(" active", "");
  	}
  	document.getElementById(tabID).style.display = "block";
  	document.getElementById(btnID).className += " active";
}

function hiddenTag(hiddenID){
	let btnToggle = document.getElementById(hiddenID);
	let ariaExpanded = btnToggle.getAttribute('aria-expanded');
	if(ariaExpanded === 'false'){
		document.getElementById(hiddenID).style.display = "block";
		btnToggle.setAttribute('aria-expanded', 'true');
	}
	else{
		document.getElementById(hiddenID).style.display = "none";
		btnToggle.setAttribute('aria-expanded', 'false');
	}
}