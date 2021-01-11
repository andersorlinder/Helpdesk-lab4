const ITHelpdeskUrl = 'http://localhost:80/IT_Helpdesk/submit';
const maintenanceHelpdeskUrl = 'http://localhost:81/Maintenance_Helpdesk/submit';
const HRHelpdeskUrl = 'http://localhost:82/HR_Helpdesk/submit';
    
async function handleFormSubmit (event) {
    event.preventDefault();
    clearAllStatus();

    const jsonString = parceFormData(event.target);
    const url = getUrl(this.id);
    const statusTag = this.querySelector(".status");
    
    const responseCode = await postRequest(url, jsonString)
    PrintStatus(responseCode);
}

function clearAllStatus() {
    const formStatusTagsdocument = document.querySelectorAll("status");
    formStatusTagsdocument.forEach(statusTag => {
        statusTag.innerHTML = "";
    });
}

function getUrl(formElementId) {
    switch (formElementId) {
        case 'ITHelpdeskForm':
            return ITHelpdeskUrl;
        case 'MaintenanceHelpdeskForm':
            return maintenanceHelpdeskUrl;
        case 'HRHelpdeskForm':
            return HRHelpdeskUrl;
    }
}

function parceFormData(eventTarget) {
    const data = new FormData(eventTarget);
    const json = Object.fromEntries(data.entries());
    return JSON.stringify(json)
}

async function postRequest (apiURL, body) {
    return await fetch(apiURL, {
        method: 'POST',
        mode: 'cors',
        headers: {
            'Content-Type': 'application/json',
            "Access-Control-Allow-Origin": "*"
        },
        body
    })
    .then(response => response.status)
    .catch();
}

function PrintStatus(responseCode) {
    if (responseCode != 200) {
        statusTag.innerHTML = "Server error, please try again"
        return;
    }
    statusTag.innerHTML = "Helpdesk registered"
}

// const ITHelpdeskForm = document.querySelector('#ITHelpdeskForm');
// ITHelpdeskForm.addEventListener('submit', postITHelpdesk);

const MaintenanceHelpdeskForm = document.querySelector('#MaintenanceHelpdeskForm');
MaintenanceHelpdeskForm.addEventListener('submit', handleFormSubmit);

// const HRHelpdeskForm = document.querySelector('#HRHelpdeskForm');
// HRHelpdeskForm.addEventListener('submit', postHRHelpdeskForm);