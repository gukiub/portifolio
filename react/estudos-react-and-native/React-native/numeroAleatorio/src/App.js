import React, {useState} from 'react';
import { Text, SafeAreaView, TouchableOpacity, StyleSheet } from 'react-native';

const App = () => {

    const [numero, setNumero] = useState(10)

    function handleNumero(){
        const novo_numero = Math.floor(Math.random() * 100)

        setNumero(novo_numero)
    }

    return (
        <SafeAreaView style={style.container}>
            <Text style={style.numero}>{numero}</Text>
            <TouchableOpacity onPress={handleNumero} style={style.botao}>
                <Text>Gerar numero</Text>
            </TouchableOpacity>
        </SafeAreaView>
    );
};

const style = StyleSheet.create({
    container: {
        backgroundColor: '#FF0000',
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center'
    },
    numero: {
        fontSize: 24,
        color: '#FFFFFF',
        fontWeight: 'bold',
    },
    botao: {
        backgroundColor: '#FFFFFF',
        width: '80%',
        paddingHorizontal: 5,
        paddingVertical: 10,
        borderRadius: 10,
        justifyContent: 'center',
        alignItems: 'center',
        marginTop: 10
    },
});

export default App;