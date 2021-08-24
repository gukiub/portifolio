import React from 'react';

const listCustomer = [
    {
        id: 1,
        name: 'Gustavo',
        skills: ['Android', 'web']
    },
    {
        id: 2,
        name: 'John',
        skills: ['React', 'Ios']
    },
    {
        id: 3,
        name: 'Marcia',
        skills: ['C#', 'Unity']
    },
    {
        id: 4,
        name: 'Leny',
        skills: ['Unreal', 'Modelagem3D']
    },
    {
        id: 5,
        name: 'Leticia',
        skills: ['Jornalismo', 'Influencer']
    },
]


const App = () => {

    const handleClick = (e, id) => {
        console.log('deletar cliente')
        alert(`id do cliente ${id}`)
    }

    const renderCustomers = (customer, index) => {
        return (
            <div key={`customer-${customer.id}`}>
                <li>{customer.name} <button onClick={(e) => handleClick(e, customer.id)}>Deletar cliente x</button></li>
                {customer.skills.map(renderSkills)}
            </div>
        )
    }

    const renderSkills = (skill, index) => {
        return(
            <div style={{paddingLeft: '30px' }} key={`skill-${index}`}>
                <li>{skill}</li>
            </div>
        )
    }
    
    return (
        <div>
            <p>teste</p>
            <p>Hello world</p>
            <div>
                <ul>
                    {listCustomer.map(renderCustomers)}
                </ul>
            </div>
        </div>
    );
};

export default App;