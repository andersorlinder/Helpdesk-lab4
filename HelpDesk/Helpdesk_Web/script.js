window.addEventListener('load', () => {
    async function postITHelpdesk(event) {
        event.preventDefault();

        const data = new FormData(event.target);
        const ITHelpdeskJSON = Object.fromEntries(data.entries());
        console.log(ITHelpdeskJSON);

        const apiURL = 'http://localhost:80/IT_Helpdesk/submit';

        // const response = await fetch(apiURL, {
        //     method: 'POST',
        //     body: ITHelpdeskJSON,
        //     mode: 'cors', // no-cors, *cors, same-origin
        //     cache: 'no-cache',
        //     credentials: 'same-origin', // include, *same-origin, omit
        //     headers: {'Content-Type': 'application/json'},
        //     redirect: 'follow', // manual, *follow, error
        //     referrerPolicy: 'no-referrer' // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
        //   });

        // console.log(response)
    }

    async function postMaintenanceHelpdesk(event) {
    }

    async function postHRHelpdeskForm(event) {
    }

    const ITHelpdeskForm = document.querySelector('#ITHelpdeskForm');
    ITHelpdeskForm.addEventListener('submit', postITHelpdesk);

    const MaintenanceHelpdeskForm = document.querySelector('#MaintenanceHelpdeskForm');
    MaintenanceHelpdeskForm.addEventListener('submit', postMaintenanceHelpdesk);

    const HRHelpdeskForm = document.querySelector('#HRHelpdeskForm');
    HRHelpdeskForm.addEventListener('submit', postHRHelpdeskForm);
});
