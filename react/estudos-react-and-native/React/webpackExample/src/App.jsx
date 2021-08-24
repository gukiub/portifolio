import React from 'react';

const buttonA = <button>Histórico dos clientes</button>

const buttonB = <button>Cadastrar cliente</button>

const hasCustomer = false

const App = () => {
    const renderShowHistory = (
    <div>
        Clique no botão abaixo para visualizar o histórico dos clientes
        <br />
        {buttonA}
    </div>
    )

    const renderAddCustomer = (
        <div>
            Clique abaixo para cadastrar o cliente
            <br />
            {buttonB}   
        </div>
    )

    const customer = 'Gustavo'

    const showCustomer = () => {
        if (!hasCustomer) return null
        
        return (
            <div>
                <h1>Nome do Cliente: Gustavo</h1>
            </div>
        )
    }

    return (
        <div>
            <p>teste</p>
            <p>Hello world</p>
            {hasCustomer ? renderShowHistory : renderAddCustomer}
            <div>
                {showCustomer()}
            </div>
        </div>
    );
};

export default App;