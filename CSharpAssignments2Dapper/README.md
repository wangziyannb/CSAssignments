#### Top-Level Options
![191ec57781427f6eba63d7c33a56e921.png](en-resource://database/1690:1)
#### Example Usage (Employees):

Input 2 to access Employees Service
![2f21c80b5da432f5b1b74211e04f8e62.png](en-resource://database/1692:1)

##### 1. Add
We can add a new Employee entity into this repository via Add service. Then this application will start import guidance.

Success:
![1f601d98389ae0439cd2c934dba2132a.png](en-resource://database/1696:1)
Failure (invalid FK in Departments):
![231c910406d3adccb734d00f0850b812.png](en-resource://database/1700:1)

##### 2. Delete
Delete an Employee using the given id.
Success:
![b50ca348300e089c55ce5985f1d3afaf.png](en-resource://database/1702:1)
Failure:
![7efdde3b677b7a37b1323c45a539a706.png](en-resource://database/1704:1)

##### 3. Update
Update an Employee using the given id.
Target:
![e5d65c6c6cc6b0f01f109557f58034e9.png](en-resource://database/1706:1)
Sucess:
![9bffa10e0645fd6f95122389077dcfa4.png](en-resource://database/1708:1)
Failure (invalid FK):
![1ccb93c7efba15a66c55fc6022f6f22e.png](en-resource://database/1710:1)

##### 4. GetById
Obtain an Employee using the given id.
Sucess:
![9cbeecb40721b614d2f7971876632b09.png](en-resource://database/1712:1)

##### 5. GetAll
Retrive all Employees.
Sucess:
![b91220363225a66fbb812724c1787a78.png](en-resource://database/1714:1)

##### 6. Return to top level
Get back to the top level, which allows changing the target to process.