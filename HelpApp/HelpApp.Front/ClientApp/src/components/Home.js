import React, { Component } from 'react';
import  axios from 'axios'
export class Home extends Component {
    static displayName = Home.name;

    componentDidMount = () => {
        axios.post("https://localhost:44388/Country/addCountry", {
            Name: 'Turkiye'
        })
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