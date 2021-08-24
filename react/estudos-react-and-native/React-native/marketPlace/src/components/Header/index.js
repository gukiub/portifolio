import React, { useState } from 'react';
import { Image } from 'react-native';

import Logo from '../../assets/logo.png';

import { Container, HeaderImage } from './styles';

const Header = () => {
    return (
        <Container>
            <HeaderImage source={Logo} />
        </Container>
    )
}

export default Header;