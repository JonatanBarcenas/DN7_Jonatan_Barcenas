const textInput = document.getElementById("text");



function showModal(message, title) {
    
    const registrationModal = document.getElementById("registrationModal");

   
    const registrationModalTitle = document.getElementById("registrationModalTitle");
    const registrationModalText = document.getElementById("registrationModalText");

   
    registrationModalTitle.textContent = title;
    registrationModalText.textContent = message;

    
    const modal = new bootstrap.Modal(registrationModal);
    modal.show();

    
    setTimeout(function () {
        modal.hide();
    }, 3000);
}


const registerButton = document.getElementById("button1");


registerButton.addEventListener("click", function (event) {
   
    event.preventDefault();

    
    const memberId = document.getElementById("text").value;

  
    const currentTime = new Date().toLocaleTimeString();

   
    
    if (registerButton.name === "memberInButton") {
        showModal(`Registered entry for the member ${memberId} at ${currentTime}.`, "check in");
    } else if (registerButton.name === "memberOutButton") {
        showModal(`Registered out for the member ${memberId} at ${currentTime}.`, "check out");
    }
});

