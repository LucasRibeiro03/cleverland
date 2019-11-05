/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow
 */

import React, { Fragment, Component } from 'react';
import {
  SafeAreaView,
  StyleSheet,
  ScrollView,
  View,
  Text,
  Button,
  TextInput,
  TouchableOpacity ,
  StatusBar,
} from 'react-native';
import { FlatList } from 'react-native-gesture-handler';


class App extends Component {
  constructor() {
    super();
    this.state = {
      listaMedicos: [],
      especialidade:"",
    };
  }

  componentDidMount() {
    this._carregarEventos();
  }

  _carregarEventos = async () => {
    // axios, fetch, xhr (XmlHttpRequest)
    await fetch('http://192.168.3.186:5000/api/medicos')
      .then(resposta => resposta.json())
      .then(data => this.setState({ listaMedicos: data }))
      .catch(erro => console.warn(erro));
  };
  _buscarEspecialidade = async (event) =>{
//     this.items = this.state.cart.map((item, key) =>
//     <li key={item.id}>{item.name}</li>
// )
    this.event
  }
  render() {
    return (
      <View>

        <Text>Cleverland</Text>
        <FlatList
          data={this.state.listaMedicos}
          keyExtractor={item => item.IdMedico}
          renderItem={({ item }) => (
            <View>
              <Text>{item.IdMedico}</Text>
              <Text>{item.nomeMedico}</Text>
              <Text>{item.especialidade}</Text>
              <Text>{item.crm}</Text>
            </View>
          )}
        />

     <View>
      <TextInput placeholder="especialidade"></TextInput>
      <TouchableOpacity onPress={this._buscarEspecialidade}>
          <Text>buscar</Text>
        </TouchableOpacity>
    </View>
      </View>
      

    );
  }

}

export default App;
