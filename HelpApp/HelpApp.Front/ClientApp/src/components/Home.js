import React, { Component } from 'react';
import  axios from 'axios'
export class Home extends Component {
    static displayName = Home.name;

    componentDidMount = () => {
        axios.get("https://localhost:44388/api/Country/countries")
            .then(response => {
                console.log(response.data);
            });

    };

    render() {
        return ( <div>
            <h1 > Help App Front</h1></div >
        );
    }
}