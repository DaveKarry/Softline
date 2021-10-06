import React, { Component } from 'react'
import {Link} from 'react-router-dom'
import {
    Form,
    FormGroup,
    Label,
    Input,
    Button,
} from 'reactstrap'
import axios from 'axios'




class AddEmployer extends Component {

    constructor(props){
        super(props)

        this.state ={
            name :'',
            surname :'',
            midname :'',
            position :'',
            note : '',
            maternityLeave : false,
            birthDate: ''
        }
    }


    handleChange = (e) =>{
        this.setState({
            [e.target.name]: e.target.value
        }) 
    }

    handleSubmit =(e) =>{
        e.preventDefault()
        console.log(JSON.stringify(this.state))
        axios({
            method: 'post',
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            url: 'https://localhost:5001/api/employers',
            data: this.state
        })
        .then(function(response) {
        
            console.log(response);
        
        })
        .catch(function (error) {
            console.log(error);
        });
        
    }



    render(){
        const {name, surname, midname, position, note, maternityLeave, birthDate } = this.state
        return (
            <Form onSubmit={this.handleSubmit}>
                <FormGroup>
                    <Label>Name</Label>
                    <Input type="text" placeholder="Ivan" name="name" value={name} onChange={this.handleChange}></Input>
                    <Label>Surname</Label>
                    <Input type="text" placeholder="Ivanov" name="surname" value={surname} onChange={this.handleChange}></Input>
                    <Label>Midname</Label>
                    <Input type="text" placeholder="Ivanich" name="midname" value={midname} onChange={this.handleChange}></Input>
                    <Label>Position</Label>
                    <Input type="text" placeholder="HR"  name="position" value={position} onChange={this.handleChange} ></Input>
                    <Label>Note</Label>
                    <Input type="text" placeholder="About..." name="note" value={note} onChange={this.handleChange}></Input>
                    <Label>BirthDate</Label>
                    <Input type="text" placeholder="2021-10-06" name="birthDate" value={birthDate} onChange={this.handleChange}></Input>
                    <FormGroup check>
                        <Label check>
                            <input type="checkbox" name="maternityLeave" value={maternityLeave} checked={this.state.maternityLeave} onChange={this.handleChange} />
                            MaternityLeave
                        </Label>
                    </FormGroup>
                   
                </FormGroup>
                <Button type="submit">Submit</Button>
                <Link to="/" className="btn btn-danger ml-2">Cancel</Link>
            </Form>
        )
    } 
}
export default AddEmployer
