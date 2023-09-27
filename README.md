# SEN381-App
Application for Premier Service Software Solutions



# Premier Service Solutions - README

## Application Requirements (Version 1.0)

### Overview
Premier Service Solutions is a company that provides maintenance on the equipment of its clients. Service contracts are entered into with clients, to maintain their equipment to contractually agreed service levels. Clients place calls to the Service Centre when they require maintenance work to be performed, where the details of the client’s problem are entered into the system. Jobs are created and assigned to technical staff members who will be responsible for executing them at the client’s location. The status of an incident is managed from the initial call, through scheduling for execution by technicians, performance of maintenance, until an incident is eventually closed when satisfactorily resolved. Full incident management through its lifecycle is required, along with escalation procedures. Management functions are required to enable viewing the state of all work in the system, taking executive action as appropriate, and measure the performance of employees in all departments. Client satisfaction is a primary priority for Premier Service Solutions, thus it is essential that the system be able to monitor, track and measure the performance of all actions. Exceptional situations must be identified and presented to appropriate users for action.

### Functional Areas

#### Call Centre
This department receives calls from clients to report faults with their equipment. When a new call is received, a call report must be created and receive a timestamp, to enable cross-referencing back to the existing call-recording software. This application must then find the client’s details in the system and display it to the user. Details of the problem are logged to the database for action by the service department. When the call ends, it receives another timestamp when the user clicks an End Call button.

##### Call Centre Requirements:
```markdown
- Answer incoming call
- Find client details
- Log details of client problem
- View customer agreement(s)
- View details of previous calls to/from client
- Submit work request if appropriate
- Add call to existing work request if appropriate
- End call
```

#### Client Maintenance
This department captures and maintains details related to clients and their service contracts. Clients are either individuals or business entities. Provision must be made for names, addresses, and contact details. Businesses must contain information about people in different roles so that the appropriate person may be contacted for the function required. All clients must be linked to their service contract(s) with the company. Provision must be made to record management information about a client, like the client’s status and ad hoc notes. The history of all contact with the client must be visible as captured by different parts of the system.

##### Client Maintenance Requirements:
```markdown
- Capture and maintain details for individual client
- Capture and maintain details for business client
- Capture details of service agreements with client
- Capture management information about client
```

#### Contract Maintenance
This department manages the types of service contracts offered by Premier Service Solutions. Offerings are created as packages of different services. Clients are then sold service contracts of the types defined by this department. A state must be managed for each offering, so that a package can be withdrawn from new sales, made available from a certain date, or offered only for a limited promotional period. This department must be able to examine the performance of different offerings from data captured by the system, to support the process of identifying opportunities for new products or measuring the profitability of existing products.

##### Contract Maintenance Requirements:
```markdown
- Define services offered
- Define service levels
- Define contract types as packages of services and service level agreements
- Manage availability of contract types
- View performance of contract types
```

#### Service Department
This department is responsible for responding to all service requests received by the Call Centre. The scheduler receives the reported incidents and assigns each to a maintenance technician who will respond to the request by performing maintenance at the client’s location. The system must enable the scheduler to match the requirements of the incident reported to the abilities of the available technicians. Responses must be scheduled taking into account the priority of the service request (as specified in the service level agreement with the client), the expected duration of the type of maintenance to be performed (as specified by this department), and other factors that may be defined later. Job specifications and daily schedules must be provided for the technicians.

Each incident must be tracked until resolution, and anomalous performance must be reported to the appropriate supervisor or manager for action. Any potential deviations should be identified early where possible and raised as a warning, so that corrective action can pre-empt potential defaulting on the terms of a service level agreement.

##### Service Department Requirements:
```markdown
- Receive service requests
- Assign requests as jobs to maintenance technicians
- Track jobs
- Escalate jobs
- Re-assign jobs when necessary
- Close service requests
```
#### Team Members
- Stephanus Jacobus Mathee [578381]
- Johan Lindeque [578382]
- Estiaan Britz [578355]
- Zander Rosslee [578293]
- Comfort Sibuyi [577231]
- Ronwynne Swanepoel [578580]
- Mufunwa nethengwe [577182]


```

This README provides an overview of the Premier Service Solutions application requirements for Version 1.0. It outlines the functional areas of the system, including the Call Centre, Client Maintenance, Contract Maintenance, and the Service Department. Each functional area includes specific requirements to be implemented.

For more detailed information on each department's requirements, please refer to the individual sections above.
```
