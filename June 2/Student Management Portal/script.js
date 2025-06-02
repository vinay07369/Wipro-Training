// Get form elements
const form = document.getElementById("student-form");
const nameInput = document.getElementById("name");
const rollInput = document.getElementById("roll");
const deptInput = document.getElementById("dept");
const emailInput = document.getElementById("email");
const tableBody = document.getElementById("studentTableBody");

let editRow = null;

// Handle form submit
form.addEventListener("submit", function (e) {
    e.preventDefault();

    const name = nameInput.value.trim();
    const roll = rollInput.value.trim();
    const dept = deptInput.value.trim();
    const email = emailInput.value.trim();

    if (!name || !roll || !dept || !email) {
        alert("Please fill in all fields.");
        return;
    }

    if (editRow) {
        // Update existing row
        editRow.cells[0].textContent = name;
        editRow.cells[1].textContent = roll;
        editRow.cells[2].textContent = dept;
        editRow.cells[3].textContent = email;

        alert("Updated Successfully!");

        editRow = null;
        form.reset();
        form.querySelector("button[type='submit']").textContent = "Add";

    } else {
        // Add new row
        const newRow = tableBody.insertRow();

        newRow.innerHTML = `
            <td>${name}</td>
            <td>${roll}</td>
            <td>${dept}</td>
            <td>${email}</td>
            <td>
                <button class="edit">Edit</button>
                <button class="delete">Delete</button>
            </td>
        `;

        form.reset();

        alert("Student Added Successfully!");
    }

    attachEventListeners();
});

// Add event listeners for Edit and Delete buttons
function attachEventListeners() {
    const editButtons = document.querySelectorAll(".edit");
    const deleteButtons = document.querySelectorAll(".delete");

    editButtons.forEach(button => {
        button.onclick = function () {
            const row = this.closest("tr");

            nameInput.value = row.cells[0].textContent;
            rollInput.value = row.cells[1].textContent;
            deptInput.value = row.cells[2].textContent;
            emailInput.value = row.cells[3].textContent;

            editRow = row;
            form.querySelector("button[type='submit']").textContent = "Update";
        };
    });

    deleteButtons.forEach(button => {
        button.onclick = function () {
            const row = this.closest("tr");
            tableBody.removeChild(row);

            if (row === editRow) {
                form.reset();
                editRow = null;
                form.querySelector("button[type='submit']").textContent = "Add";
            }

            alert("Deleted Successfully!");
        };
    });
}