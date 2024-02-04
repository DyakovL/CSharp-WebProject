function TogglePasswordFunc() {
    // Select the password input and the eye icon
    const passwordInput = document.querySelector("#password");
    const eye = document.querySelector("#eye");

    // Check the current class of the eye icon
    const isEyeSlash = eye.classList.contains("fa-eye-slash");

    // Toggle the classes based on the current state
    if (isEyeSlash) {
        eye.classList.remove("fa-eye-slash");
        eye.classList.add("far-fa-eye");
    } else {
        eye.classList.remove("far-fa-eye");
        eye.classList.add("fa-eye-slash");
    }

    // Toggle the visibility of the password input
    const type = passwordInput.getAttribute("type") === "password" ? "text" : "password";
    passwordInput.setAttribute("type", type);
}

function LoginUser() {
    //get the username
    const username = document.querySelector("#username");

    //get the password
    const password = document.querySelector("#password");

    let loginDataIsValid = false;

    

    loginDataIsValid = validData(username, password);
}