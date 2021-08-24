import axios from 'axios';

const api = axios.create({
    baseURL: 'http://localhost:3000', // Mac OS
    // baseURL: 'http://10.0.2.2:8080', // Emulador do android
    // baseURL: 'http://10.0.2.2:8080', // android
    // baseURL: 'http://192.168.15.18:8080', // USB
});

export default api;