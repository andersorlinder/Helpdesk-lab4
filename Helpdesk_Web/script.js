const ITHelpdeskUrl = 'http://localhost:80/IT_Helpdesk/submit';
const maintenanceHelpdeskUrl = 'http://localhost:81/Maintenance_Helpdesk/submit';
const HRHelpdeskUrl = 'http://localhost:82/HR_Helpdesk/submit';

    
// async function postITHelpdesk(event) {
//     event.preventDefault();

//     const data = new FormData(event.target);
//     const json = Object.fromEntries(data.entries());
//     console.log(json);

//     const apiURL = 'http://localhost:80/IT_Helpdesk/submit';

//     const response = await postRequest(apiURL, json)
// }

async function postMaintenanceHelpdesk (event) {
    event.preventDefault();
    const formStatusTagsdocument = document.querySelectorAll("status");
    formStatusTagsdocument.forEach(statusTag => {
        statusTag.innerHTML = "";
    });

    let url;
    switch (this.id) {
        case 'ITHelpdeskForm':
            url = ITHelpdeskUrl;
            break;
        case 'MaintenanceHelpdeskForm':
            url = maintenanceHelpdeskUrl;
            break;
        case 'HRHelpdeskForm':
            url = HRHelpdeskUrl;
            break;
        default:
            break;
    }
    
    const data = new FormData(event.target);
    const json = Object.fromEntries(data.entries());
    
    const responseCode = await postRequest(url, json)

    var statusTag = this.querySelector(".status");
    if (responseCode != 200) {
        statusTag.innerHTML = "Server error, please try again"
        return;
    }

    statusTag.innerHTML = "Helpdesk registered"
}

async function postRequest (apiURL, json) {
    return await fetch(apiURL, {
        method: 'POST',
        mode: 'cors',
        headers: {
            'Content-Type': 'application/json',
            "Access-Control-Allow-Origin": "*"
        },
        body: JSON.stringify(json)
    })
    .then(response => response.status)
    .catch();
}

// const ITHelpdeskForm = document.querySelector('#ITHelpdeskForm');
// ITHelpdeskForm.addEventListener('submit', postITHelpdesk);

const MaintenanceHelpdeskForm = document.querySelector('#MaintenanceHelpdeskForm');
MaintenanceHelpdeskForm.addEventListener('submit', postMaintenanceHelpdesk);

// const HRHelpdeskForm = document.querySelector('#HRHelpdeskForm');
// HRHelpdeskForm.addEventListener('submit', postHRHelpdeskForm);
